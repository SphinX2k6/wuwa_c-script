using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029C RID: 668
	[UnrealObjectPath("/Script/Engine.TextureLightProfile")]
	[UnrealStructLayout(4240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4240)]
	public class UTextureLightProfile : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600497A RID: 18810 RVA: 0x000670A6 File Offset: 0x000652A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureLightProfile._ClassPtr;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x000670B4 File Offset: 0x000652B4
		public UTextureLightProfile() : this(BuiltinUtils.AllocNativeUObject(UTextureLightProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x000670DC File Offset: 0x000652DC
		[NullableContext(1)]
		public UTextureLightProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureLightProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x0006710F File Offset: 0x0006530F
		// (set) Token: 0x0600497E RID: 18814 RVA: 0x0006711F File Offset: 0x0006531F
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureLightProfile.__PropertyOffset_Brightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureLightProfile.__PropertyOffset_Brightness) = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x00067130 File Offset: 0x00065330
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x00067140 File Offset: 0x00065340
		public unsafe float TextureMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureLightProfile.__PropertyOffset_TextureMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureLightProfile.__PropertyOffset_TextureMultiplier) = value;
			}
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x00067151 File Offset: 0x00065351
		static UTextureLightProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureLightProfile");
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x0006715F File Offset: 0x0006535F
		protected UTextureLightProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CCF RID: 7375
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureLightProfile";

		// Token: 0x04001CD0 RID: 7376
		private static IntPtr _ClassPtr;

		// Token: 0x04001CD1 RID: 7377
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001CD2 RID: 7378
		internal static int __PropertyOffset_Brightness;

		// Token: 0x04001CD3 RID: 7379
		internal static int __PropertyOffset_TextureMultiplier;
	}
}
