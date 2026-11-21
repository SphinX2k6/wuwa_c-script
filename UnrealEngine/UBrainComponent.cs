using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000AD RID: 173
	[UnrealObjectPath("/Script/AIModule.BrainComponent")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UBrainComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x00014D57 File Offset: 0x00012F57
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrainComponent._ClassPtr;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00014D64 File Offset: 0x00012F64
		public UBrainComponent() : this(BuiltinUtils.AllocNativeUObject(UBrainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00014D8C File Offset: 0x00012F8C
		[NullableContext(1)]
		public UBrainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00014DBF File Offset: 0x00012FBF
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00014DD3 File Offset: 0x00012FD3
		[Nullable(2)]
		public unsafe AAIController AIOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UBrainComponent.__PropertyOffset_AIOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrainComponent.__PropertyOffset_AIOwner, value);
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00014DE8 File Offset: 0x00012FE8
		[NullableContext(1)]
		public unsafe void StopLogic(string Reason)
		{
			FString fstring = FString.AllocTemp(Reason);
			UBrainComponent.__StopLogic_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00014E12 File Offset: 0x00013012
		public void StartLogic()
		{
			UBrainComponent.__StartLogic_Internal(base.NativePtr);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00014E1F File Offset: 0x0001301F
		public void RestartLogic()
		{
			UBrainComponent.__RestartLogic_Internal(base.NativePtr);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00014E2C File Offset: 0x0001302C
		public bool IsRunning()
		{
			return UBrainComponent.__IsRunning_Internal(base.NativePtr);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00014E39 File Offset: 0x00013039
		public bool IsPaused()
		{
			return UBrainComponent.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x06000D2A RID: 3370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopLogic_Internal(IntPtr @this, in FString Reason);

		// Token: 0x06000D2B RID: 3371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartLogic_Internal(IntPtr @this);

		// Token: 0x06000D2C RID: 3372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartLogic_Internal(IntPtr @this);

		// Token: 0x06000D2D RID: 3373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRunning_Internal(IntPtr @this);

		// Token: 0x06000D2E RID: 3374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x06000D2F RID: 3375 RVA: 0x00014E46 File Offset: 0x00013046
		static UBrainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BrainComponent");
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00014E54 File Offset: 0x00013054
		protected UBrainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000242 RID: 578
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BrainComponent";

		// Token: 0x04000243 RID: 579
		private static IntPtr _ClassPtr;

		// Token: 0x04000244 RID: 580
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000245 RID: 581
		internal static int __PropertyOffset_AIOwner;
	}
}
