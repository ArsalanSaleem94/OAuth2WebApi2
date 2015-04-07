using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

namespace Application
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                Provider = new OAuthAuthorizationServerProvider()
                {
                    OnValidateClientAuthentication = async c =>
                    {
                        c.Validated();
                    },
                    OnGrantResourceOwnerCredentials = async c =>
                        {
                            if ((c.UserName == "Masology") && (c.Password == "1314dfdss24ds3"))
                            {
                                ClaimsIdentity id = new ClaimsIdentity(
                                    new Claim[]{
                                        new Claim(ClaimTypes.Name, c.UserName)},
                                        OAuthDefaults.AuthenticationType);
                                c.Validated(id);
                            }
                        }
                }
            });
        }
    }
}