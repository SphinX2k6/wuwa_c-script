using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CAA RID: 3242
	[UnrealObjectPath("/Script/Engine.InterpTrackInstToggle")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInterpTrackInstToggle : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A402 RID: 41986 RVA: 0x000E924C File Offset: 0x000E744C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstToggle._ClassPtr;
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x000E9258 File Offset: 0x000E7458
		public UInterpTrackInstToggle() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstToggle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x000E9280 File Offset: 0x000E7480
		[NullableContext(1)]
		public UInterpTrackInstToggle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstToggle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x000E92B3 File Offset: 0x000E74B3
		// (set) Token: 0x0600A406 RID: 41990 RVA: 0x000E92C7 File Offset: 0x000E74C7
		public unsafe TEnumAsByte<ETrackToggleAction> Action
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_Action);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_Action) = value;
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x000E92DC File Offset: 0x000E74DC
		// (set) Token: 0x0600A408 RID: 41992 RVA: 0x000E92EC File Offset: 0x000E74EC
		public unsafe float LastUpdatePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_LastUpdatePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_LastUpdatePosition) = value;
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600A409 RID: 41993 RVA: 0x000E92FD File Offset: 0x000E74FD
		// (set) Token: 0x0600A40A RID: 41994 RVA: 0x000E9316 File Offset: 0x000E7516
		public unsafe bool bSavedActiveState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_bSavedActiveState) & UInterpTrackInstToggle.__PropertyMask_bSavedActiveState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_bSavedActiveState) = ((*(base.NativePtr + (IntPtr)UInterpTrackInstToggle.__PropertyOffset_bSavedActiveState) & ~UInterpTrackInstToggle.__PropertyMask_bSavedActiveState) | (value ? UInterpTrackInstToggle.__PropertyMask_bSavedActiveState : 0));
			}
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x000E9346 File Offset: 0x000E7546
		static UInterpTrackInstToggle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstToggle");
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x000E9354 File Offset: 0x000E7554
		protected UInterpTrackInstToggle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A26 RID: 23078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstToggle";

		// Token: 0x04005A27 RID: 23079
		private static IntPtr _ClassPtr;

		// Token: 0x04005A28 RID: 23080
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A29 RID: 23081
		internal static int __PropertyOffset_Action;

		// Token: 0x04005A2A RID: 23082
		internal static int __PropertyOffset_LastUpdatePosition;

		// Token: 0x04005A2B RID: 23083
		internal static int __PropertyOffset_bSavedActiveState;

		// Token: 0x04005A2C RID: 23084
		internal static byte __PropertyMask_bSavedActiveState;
	}
}
