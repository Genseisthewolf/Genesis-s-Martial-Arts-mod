using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Genepunch.Projectiles
{
    internal class SoaringFistProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 48;
            Projectile.height = 48;

            Projectile.friendly= true;
            Projectile.tileCollide= false;
            Projectile.ignoreWater= true;

            Projectile.DamageType = DamageClass.Ranged;

            Projectile.aiStyle= -1;
            Projectile.penetrate = -1;

        }
        public override void AI()
        {
            Projectile.ai[0]++;
            if (Projectile.ai[0] > 60f) 
            {
                Projectile.velocity *= 1.01f;
            } else
            {
                Projectile.velocity *= 1.05f;
                if (Projectile.ai[0] >= 180)
                {
                    Projectile.Kill();
                }
            }
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            DrawOffsetX = -((48 / 2) - halfProjWidth);
            DrawOriginOffsetY = -((48 / 2) - halfProjHeight);
        }

    }
}
