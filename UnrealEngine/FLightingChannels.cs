using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D49 RID: 3401
	[UnrealObjectPath("/Script/Engine.LightingChannels")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FLightingChannels : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B7A8 RID: 47016 RVA: 0x001053F1 File Offset: 0x001035F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightingChannels._ScriptStructPtr != 0) ? FLightingChannels._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightingChannels", ref FLightingChannels._ScriptStructPtr);
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x00105415 File Offset: 0x00103615
		// (set) Token: 0x0600B7AA RID: 47018 RVA: 0x0010542E File Offset: 0x0010362E
		public unsafe bool bChannel0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel0) & FLightingChannels.__PropertyMask_bChannel0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel0) = ((*(base.NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel0) & ~FLightingChannels.__PropertyMask_bChannel0) | (value ? FLightingChannels.__PropertyMask_bChannel0 : 0));
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0600B7AB RID: 47019 RVA: 0x0010545E File Offset: 0x0010365E
		// (set) Token: 0x0600B7AC RID: 47020 RVA: 0x00105477 File Offset: 0x00103677
		public unsafe bool bChannel1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel1) & FLightingChannels.__PropertyMask_bChannel1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel1) = ((*(base.NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel1) & ~FLightingChannels.__PropertyMask_bChannel1) | (value ? FLightingChannels.__PropertyMask_bChannel1 : 0));
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x001054A7 File Offset: 0x001036A7
		// (set) Token: 0x0600B7AE RID: 47022 RVA: 0x001054C0 File Offset: 0x001036C0
		public unsafe bool bChannel2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel2) & FLightingChannels.__PropertyMask_bChannel2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel2) = ((*(base.NativePtr + (IntPtr)FLightingChannels.__PropertyOffset_bChannel2) & ~FLightingChannels.__PropertyMask_bChannel2) | (value ? FLightingChannels.__PropertyMask_bChannel2 : 0));
			}
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x001054F0 File Offset: 0x001036F0
		public FLightingChannels()
		{
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x001054F8 File Offset: 0x001036F8
		public FLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			this.bChannel0 = bChannel0;
			this.bChannel1 = bChannel1;
			this.bChannel2 = bChannel2;
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x00105515 File Offset: 0x00103715
		protected override IntPtr GetUStructPtr()
		{
			return FLightingChannels.StaticStruct();
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x00105521 File Offset: 0x00103721
		[NullableContext(2)]
		public FLightingChannels(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x0010552B File Offset: 0x0010372B
		public FLightingChannels(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x00105536 File Offset: 0x00103736
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightingChannels(Pointer, false, true);
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x00105540 File Offset: 0x00103740
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightingChannels(Pointer, MemoryOwner);
		}

		// Token: 0x04006030 RID: 24624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightingChannels";

		// Token: 0x04006031 RID: 24625
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006032 RID: 24626
		internal static int __PropertyOffset_bChannel0;

		// Token: 0x04006033 RID: 24627
		internal static byte __PropertyMask_bChannel0;

		// Token: 0x04006034 RID: 24628
		internal static int __PropertyOffset_bChannel1;

		// Token: 0x04006035 RID: 24629
		internal static byte __PropertyMask_bChannel1;

		// Token: 0x04006036 RID: 24630
		internal static int __PropertyOffset_bChannel2;

		// Token: 0x04006037 RID: 24631
		internal static byte __PropertyMask_bChannel2;
	}
}
