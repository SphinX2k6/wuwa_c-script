using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AB RID: 939
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.KSC_HeadStateManager")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_HeadStateManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005CF6 RID: 23798 RVA: 0x00082D30 File Offset: 0x00080F30
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_HeadStateManager._ClassPtr;
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x00082D3C File Offset: 0x00080F3C
		public UKSC_HeadStateManager() : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x00082D64 File Offset: 0x00080F64
		[NullableContext(1)]
		public UKSC_HeadStateManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x00082D97 File Offset: 0x00080F97
		// (set) Token: 0x06005CFA RID: 23802 RVA: 0x00082DAB File Offset: 0x00080FAB
		public unsafe UKSC_World KscWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateManager.__PropertyOffset_KscWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateManager.__PropertyOffset_KscWorld, value);
			}
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00082DC0 File Offset: 0x00080FC0
		public unsafe void Update(in float DeltaTime, in FVectorDouble CameraLocation)
		{
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				UKSC_HeadStateManager.__Update_Internal(base.NativePtr, DeltaTime, CameraLocation);
			}
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00082DE4 File Offset: 0x00080FE4
		public void InitAllRes(USceneComponent Parent, AUIBaseActor DynamicBatchActor, AUIBaseActor HeadStateActor, UCurveFloat ScaleCurve)
		{
			UKSC_HeadStateManager.__InitAllRes_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, (DynamicBatchActor != null) ? DynamicBatchActor.NativePtr : IntPtr.Zero, (HeadStateActor != null) ? HeadStateActor.NativePtr : IntPtr.Zero, (ScaleCurve != null) ? ScaleCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00082E3E File Offset: 0x0008103E
		public static UKSC_HeadStateManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_HeadStateManager>(UKSC_HeadStateManager.__GetInstance_Internal());
		}

		// Token: 0x06005CFE RID: 23806
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x06005CFF RID: 23807 RVA: 0x00082E4A File Offset: 0x0008104A
		public static UKSC_HeadStateManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_HeadStateManager>(UKSC_HeadStateManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06005D00 RID: 23808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, in float DeltaTime, in FVectorDouble CameraLocation);

		// Token: 0x06005D01 RID: 23809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitAllRes_Internal(IntPtr @this, IntPtr Parent, IntPtr DynamicBatchActor, IntPtr HeadStateActor, IntPtr ScaleCurve);

		// Token: 0x06005D02 RID: 23810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x06005D03 RID: 23811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x06005D04 RID: 23812 RVA: 0x00082E66 File Offset: 0x00081066
		static UKSC_HeadStateManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.KSC_HeadStateManager");
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x00082E74 File Offset: 0x00081074
		protected UKSC_HeadStateManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040026C4 RID: 9924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.KSC_HeadStateManager";

		// Token: 0x040026C5 RID: 9925
		private static IntPtr _ClassPtr;

		// Token: 0x040026C6 RID: 9926
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040026C7 RID: 9927
		internal static int __PropertyOffset_KscWorld;
	}
}
