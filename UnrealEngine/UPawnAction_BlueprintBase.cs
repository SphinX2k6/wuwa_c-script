using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D8 RID: 472
	[UnrealObjectPath("/Script/AIModule.PawnAction_BlueprintBase")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public abstract class UPawnAction_BlueprintBase : UPawnAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BDB RID: 7131 RVA: 0x00029819 File Offset: 0x00027A19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnAction_BlueprintBase._ClassPtr;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00029825 File Offset: 0x00027A25
		[NullableContext(2)]
		public virtual void ActionTick(APawn ControlledPawn, float DeltaSeconds)
		{
			UPawnAction_BlueprintBase.__ActionTick_Internal(base.NativePtr, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00029843 File Offset: 0x00027A43
		[NullableContext(2)]
		public virtual void ActionStart(APawn ControlledPawn)
		{
			UPawnAction_BlueprintBase.__ActionStart_Internal(base.NativePtr, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00029860 File Offset: 0x00027A60
		[NullableContext(2)]
		public virtual void ActionResume(APawn ControlledPawn)
		{
			UPawnAction_BlueprintBase.__ActionResume_Internal(base.NativePtr, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0002987D File Offset: 0x00027A7D
		[NullableContext(2)]
		public virtual void ActionPause(APawn ControlledPawn)
		{
			UPawnAction_BlueprintBase.__ActionPause_Internal(base.NativePtr, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0002989A File Offset: 0x00027A9A
		[NullableContext(2)]
		public virtual void ActionFinished(APawn ControlledPawn, EPawnActionResult WithResult)
		{
			UPawnAction_BlueprintBase.__ActionFinished_Internal(base.NativePtr, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, WithResult);
		}

		// Token: 0x06001BE1 RID: 7137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActionTick_Internal(IntPtr @this, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x06001BE2 RID: 7138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActionStart_Internal(IntPtr @this, IntPtr ControlledPawn);

		// Token: 0x06001BE3 RID: 7139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActionResume_Internal(IntPtr @this, IntPtr ControlledPawn);

		// Token: 0x06001BE4 RID: 7140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActionPause_Internal(IntPtr @this, IntPtr ControlledPawn);

		// Token: 0x06001BE5 RID: 7141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActionFinished_Internal(IntPtr @this, IntPtr ControlledPawn, TEnumAsByte<EPawnActionResult> WithResult);

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000298BD File Offset: 0x00027ABD
		static UPawnAction_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnAction_BlueprintBase");
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000298CC File Offset: 0x00027ACC
		protected UPawnAction_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UPawnAction_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000298F4 File Offset: 0x00027AF4
		protected UPawnAction_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008F7 RID: 2295
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnAction_BlueprintBase";

		// Token: 0x040008F8 RID: 2296
		private static IntPtr _ClassPtr;

		// Token: 0x040008F9 RID: 2297
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02002B71 RID: 11121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ActionTick_FunctionParams
		{
			// Token: 0x040163FA RID: 91130
			[FieldOffset(0)]
			public IntPtr ControlledPawn;

			// Token: 0x040163FB RID: 91131
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B72 RID: 11122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ActionStart_FunctionParams
		{
			// Token: 0x040163FC RID: 91132
			[FieldOffset(0)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B73 RID: 11123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ActionResume_FunctionParams
		{
			// Token: 0x040163FD RID: 91133
			[FieldOffset(0)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B74 RID: 11124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ActionPause_FunctionParams
		{
			// Token: 0x040163FE RID: 91134
			[FieldOffset(0)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B75 RID: 11125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ActionFinished_FunctionParams
		{
			// Token: 0x040163FF RID: 91135
			[FieldOffset(0)]
			public IntPtr ControlledPawn;

			// Token: 0x04016400 RID: 91136
			[FieldOffset(8)]
			public TEnumAsByte<EPawnActionResult> WithResult;
		}
	}
}
