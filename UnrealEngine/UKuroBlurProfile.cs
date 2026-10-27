using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002515 RID: 9493
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.KuroBlurProfile")]
	[UnrealStructLayout(960, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 960)]
	public class UKuroBlurProfile : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023418 RID: 144408 RVA: 0x003424BF File Offset: 0x003406BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBlurProfile._ClassPtr;
		}

		// Token: 0x06023419 RID: 144409 RVA: 0x003424CC File Offset: 0x003406CC
		public UKuroBlurProfile() : this(BuiltinUtils.AllocNativeUObject(UKuroBlurProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602341A RID: 144410 RVA: 0x003424F4 File Offset: 0x003406F4
		public UKuroBlurProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBlurProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008788 RID: 34696
		// (get) Token: 0x0602341B RID: 144411 RVA: 0x00342528 File Offset: 0x00340728
		// (set) Token: 0x0602341C RID: 144412 RVA: 0x00342561 File Offset: 0x00340761
		public FKuroBlurSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FKuroBlurSettings(base.NativePtr + (IntPtr)UKuroBlurProfile.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroBlurProfile.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602341D RID: 144413 RVA: 0x00342582 File Offset: 0x00340782
		static UKuroBlurProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.KuroBlurProfile");
		}

		// Token: 0x0602341E RID: 144414 RVA: 0x00342590 File Offset: 0x00340790
		protected UKuroBlurProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012ED4 RID: 77524
		public new const string __ObjectPath = "/Script/Niagara.KuroBlurProfile";

		// Token: 0x04012ED5 RID: 77525
		private static IntPtr _ClassPtr;

		// Token: 0x04012ED6 RID: 77526
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012ED7 RID: 77527
		internal static int __PropertyOffset_Settings;

		// Token: 0x04012ED8 RID: 77528
		[Nullable(2)]
		private FKuroBlurSettings _Settings;
	}
}
