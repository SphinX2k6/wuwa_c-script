using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001BE RID: 446
	[UnrealObjectPath("/Script/Engine.CullDistanceVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ACullDistanceVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020CF RID: 8399 RVA: 0x000302D5 File Offset: 0x0002E4D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACullDistanceVolume._ClassPtr;
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000302E4 File Offset: 0x0002E4E4
		public ACullDistanceVolume() : this(BuiltinUtils.AllocNativeUObject(ACullDistanceVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0003030C File Offset: 0x0002E50C
		[NullableContext(1)]
		public ACullDistanceVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACullDistanceVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0003033F File Offset: 0x0002E53F
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00030358 File Offset: 0x0002E558
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_bEnabled) & ACullDistanceVolume.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)ACullDistanceVolume.__PropertyOffset_bEnabled) & ~ACullDistanceVolume.__PropertyMask_bEnabled) | (value ? ACullDistanceVolume.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00030388 File Offset: 0x0002E588
		static ACullDistanceVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CullDistanceVolume");
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00030396 File Offset: 0x0002E596
		protected ACullDistanceVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AE0 RID: 2784
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CullDistanceVolume";

		// Token: 0x04000AE1 RID: 2785
		private static IntPtr _ClassPtr;

		// Token: 0x04000AE2 RID: 2786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AE3 RID: 2787
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04000AE4 RID: 2788
		internal static byte __PropertyMask_bEnabled;
	}
}
