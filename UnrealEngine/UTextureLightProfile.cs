using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011D7 RID: 4567
	[UnrealObjectPath("/Script/Engine.TextureLightProfile")]
	[UnrealStructLayout(4048, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4048)]
	public class UTextureLightProfile : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D1E RID: 68894 RVA: 0x0018B3E4 File Offset: 0x001895E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureLightProfile._ClassPtr;
		}

		// Token: 0x06010D1F RID: 68895 RVA: 0x0018B3F0 File Offset: 0x001895F0
		public UTextureLightProfile() : this(BuiltinUtils.AllocNativeUObject(UTextureLightProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D20 RID: 68896 RVA: 0x0018B418 File Offset: 0x00189618
		[NullableContext(1)]
		public UTextureLightProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureLightProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x06010D21 RID: 68897 RVA: 0x0018B44B File Offset: 0x0018964B
		// (set) Token: 0x06010D22 RID: 68898 RVA: 0x0018B45B File Offset: 0x0018965B
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

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x06010D23 RID: 68899 RVA: 0x0018B46C File Offset: 0x0018966C
		// (set) Token: 0x06010D24 RID: 68900 RVA: 0x0018B47C File Offset: 0x0018967C
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

		// Token: 0x06010D25 RID: 68901 RVA: 0x0018B48D File Offset: 0x0018968D
		static UTextureLightProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureLightProfile");
		}

		// Token: 0x06010D26 RID: 68902 RVA: 0x0018B49B File Offset: 0x0018969B
		protected UTextureLightProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009023 RID: 36899
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureLightProfile";

		// Token: 0x04009024 RID: 36900
		private static IntPtr _ClassPtr;

		// Token: 0x04009025 RID: 36901
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009026 RID: 36902
		internal static int __PropertyOffset_Brightness;

		// Token: 0x04009027 RID: 36903
		internal static int __PropertyOffset_TextureMultiplier;
	}
}
