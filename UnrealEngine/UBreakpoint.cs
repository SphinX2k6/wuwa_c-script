using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008F3 RID: 2291
	[UnrealObjectPath("/Script/Engine.Breakpoint")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UBreakpoint : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DA8 RID: 32168 RVA: 0x000B40AC File Offset: 0x000B22AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBreakpoint._ClassPtr;
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x000B40B8 File Offset: 0x000B22B8
		public UBreakpoint() : this(BuiltinUtils.AllocNativeUObject(UBreakpoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x000B40E0 File Offset: 0x000B22E0
		[NullableContext(1)]
		public UBreakpoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBreakpoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06007DAB RID: 32171 RVA: 0x000B4113 File Offset: 0x000B2313
		// (set) Token: 0x06007DAC RID: 32172 RVA: 0x000B412C File Offset: 0x000B232C
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bEnabled) & UBreakpoint.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bEnabled) & ~UBreakpoint.__PropertyMask_bEnabled) | (value ? UBreakpoint.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x000B415C File Offset: 0x000B235C
		// (set) Token: 0x06007DAE RID: 32174 RVA: 0x000B4170 File Offset: 0x000B2370
		[Nullable(2)]
		public unsafe UEdGraphNode Node
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEdGraphNode>(base.NativePtr / (IntPtr)sizeof(void*) + UBreakpoint.__PropertyOffset_Node);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBreakpoint.__PropertyOffset_Node, value);
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06007DAF RID: 32175 RVA: 0x000B4185 File Offset: 0x000B2385
		// (set) Token: 0x06007DB0 RID: 32176 RVA: 0x000B419E File Offset: 0x000B239E
		public unsafe bool bStepOnce
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce) & UBreakpoint.__PropertyMask_bStepOnce) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce) = ((*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce) & ~UBreakpoint.__PropertyMask_bStepOnce) | (value ? UBreakpoint.__PropertyMask_bStepOnce : 0));
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x000B41CE File Offset: 0x000B23CE
		// (set) Token: 0x06007DB2 RID: 32178 RVA: 0x000B41E7 File Offset: 0x000B23E7
		public unsafe bool bStepOnce_WasPreviouslyDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce_WasPreviouslyDisabled) & UBreakpoint.__PropertyMask_bStepOnce_WasPreviouslyDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce_WasPreviouslyDisabled) = ((*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce_WasPreviouslyDisabled) & ~UBreakpoint.__PropertyMask_bStepOnce_WasPreviouslyDisabled) | (value ? UBreakpoint.__PropertyMask_bStepOnce_WasPreviouslyDisabled : 0));
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x000B4217 File Offset: 0x000B2417
		// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x000B4230 File Offset: 0x000B2430
		public unsafe bool bStepOnce_RemoveAfterHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce_RemoveAfterHit) & UBreakpoint.__PropertyMask_bStepOnce_RemoveAfterHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce_RemoveAfterHit) = ((*(base.NativePtr + (IntPtr)UBreakpoint.__PropertyOffset_bStepOnce_RemoveAfterHit) & ~UBreakpoint.__PropertyMask_bStepOnce_RemoveAfterHit) | (value ? UBreakpoint.__PropertyMask_bStepOnce_RemoveAfterHit : 0));
			}
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x000B4260 File Offset: 0x000B2460
		static UBreakpoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Breakpoint");
		}

		// Token: 0x06007DB6 RID: 32182 RVA: 0x000B426E File Offset: 0x000B246E
		protected UBreakpoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003C2F RID: 15407
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Breakpoint";

		// Token: 0x04003C30 RID: 15408
		private static IntPtr _ClassPtr;

		// Token: 0x04003C31 RID: 15409
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003C32 RID: 15410
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04003C33 RID: 15411
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04003C34 RID: 15412
		internal static int __PropertyOffset_Node;

		// Token: 0x04003C35 RID: 15413
		internal static int __PropertyOffset_bStepOnce;

		// Token: 0x04003C36 RID: 15414
		internal static byte __PropertyMask_bStepOnce;

		// Token: 0x04003C37 RID: 15415
		internal static int __PropertyOffset_bStepOnce_WasPreviouslyDisabled;

		// Token: 0x04003C38 RID: 15416
		internal static byte __PropertyMask_bStepOnce_WasPreviouslyDisabled;

		// Token: 0x04003C39 RID: 15417
		internal static int __PropertyOffset_bStepOnce_RemoveAfterHit;

		// Token: 0x04003C3A RID: 15418
		internal static byte __PropertyMask_bStepOnce_RemoveAfterHit;
	}
}
