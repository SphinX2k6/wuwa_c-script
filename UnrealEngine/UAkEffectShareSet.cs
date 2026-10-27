using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000201 RID: 513
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkEffectShareSet")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UAkEffectShareSet : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E37 RID: 7735 RVA: 0x0002CCB3 File Offset: 0x0002AEB3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkEffectShareSet._ClassPtr;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		public UAkEffectShareSet() : this(BuiltinUtils.AllocNativeUObject(UAkEffectShareSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		public UAkEffectShareSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkEffectShareSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x0002CD1C File Offset: 0x0002AF1C
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0002CD55 File Offset: 0x0002AF55
		public FWwiseLocalizedShareSetCookedData ShareSetCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseLocalizedShareSetCookedData result;
				if ((result = this._ShareSetCookedData) == null)
				{
					result = (this._ShareSetCookedData = new FWwiseLocalizedShareSetCookedData(base.NativePtr + (IntPtr)UAkEffectShareSet.__PropertyOffset_ShareSetCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseLocalizedShareSetCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkEffectShareSet.__PropertyOffset_ShareSetCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0002CD76 File Offset: 0x0002AF76
		static UAkEffectShareSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkEffectShareSet");
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0002CD84 File Offset: 0x0002AF84
		protected UAkEffectShareSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A04 RID: 2564
		public new const string __ObjectPath = "/Script/AkAudio.AkEffectShareSet";

		// Token: 0x04000A05 RID: 2565
		private static IntPtr _ClassPtr;

		// Token: 0x04000A06 RID: 2566
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A07 RID: 2567
		internal static int __PropertyOffset_ShareSetCookedData;

		// Token: 0x04000A08 RID: 2568
		[Nullable(2)]
		private FWwiseLocalizedShareSetCookedData _ShareSetCookedData;
	}
}
