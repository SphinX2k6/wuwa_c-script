using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011B6 RID: 4534
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SubsurfaceProfile")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class USubsurfaceProfile : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010B74 RID: 68468 RVA: 0x00188A6A File Offset: 0x00186C6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubsurfaceProfile._ClassPtr;
		}

		// Token: 0x06010B75 RID: 68469 RVA: 0x00188A78 File Offset: 0x00186C78
		public USubsurfaceProfile() : this(BuiltinUtils.AllocNativeUObject(USubsurfaceProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010B76 RID: 68470 RVA: 0x00188AA0 File Offset: 0x00186CA0
		public USubsurfaceProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubsurfaceProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x06010B77 RID: 68471 RVA: 0x00188AD4 File Offset: 0x00186CD4
		// (set) Token: 0x06010B78 RID: 68472 RVA: 0x00188B0D File Offset: 0x00186D0D
		public FSubsurfaceProfileStruct Settings
		{
			get
			{
				base.FastCheckIsValid();
				FSubsurfaceProfileStruct result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FSubsurfaceProfileStruct(base.NativePtr + (IntPtr)USubsurfaceProfile.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSubsurfaceProfileStruct.StaticStruct(), base.NativePtr + (IntPtr)USubsurfaceProfile.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010B79 RID: 68473 RVA: 0x00188B2E File Offset: 0x00186D2E
		static USubsurfaceProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SubsurfaceProfile");
		}

		// Token: 0x06010B7A RID: 68474 RVA: 0x00188B3C File Offset: 0x00186D3C
		protected USubsurfaceProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008EFD RID: 36605
		public new const string __ObjectPath = "/Script/Engine.SubsurfaceProfile";

		// Token: 0x04008EFE RID: 36606
		private static IntPtr _ClassPtr;

		// Token: 0x04008EFF RID: 36607
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F00 RID: 36608
		internal static int __PropertyOffset_Settings;

		// Token: 0x04008F01 RID: 36609
		[Nullable(2)]
		private FSubsurfaceProfileStruct _Settings;
	}
}
