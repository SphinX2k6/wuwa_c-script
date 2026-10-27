using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001885 RID: 6277
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.KSC_HeadStateManager")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_HeadStateManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017225 RID: 94757 RVA: 0x0021B50E File Offset: 0x0021970E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_HeadStateManager._ClassPtr;
		}

		// Token: 0x06017226 RID: 94758 RVA: 0x0021B51C File Offset: 0x0021971C
		public UKSC_HeadStateManager() : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017227 RID: 94759 RVA: 0x0021B544 File Offset: 0x00219744
		[NullableContext(1)]
		public UKSC_HeadStateManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D19 RID: 23833
		// (get) Token: 0x06017228 RID: 94760 RVA: 0x0021B577 File Offset: 0x00219777
		// (set) Token: 0x06017229 RID: 94761 RVA: 0x0021B58B File Offset: 0x0021978B
		public unsafe UKSC_HeadStateDynamicBatchView DynamicBatchView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_HeadStateDynamicBatchView>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateManager.__PropertyOffset_DynamicBatchView);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateManager.__PropertyOffset_DynamicBatchView, value);
			}
		}

		// Token: 0x17005D1A RID: 23834
		// (get) Token: 0x0601722A RID: 94762 RVA: 0x0021B5A0 File Offset: 0x002197A0
		// (set) Token: 0x0601722B RID: 94763 RVA: 0x0021B5B4 File Offset: 0x002197B4
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

		// Token: 0x0601722C RID: 94764 RVA: 0x0021B5CC File Offset: 0x002197CC
		public unsafe void Update(in float DeltaTime, in FVectorDouble CameraLocation)
		{
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				UKSC_HeadStateManager.__Update_Internal(base.NativePtr, DeltaTime, CameraLocation);
			}
		}

		// Token: 0x0601722D RID: 94765 RVA: 0x0021B5F0 File Offset: 0x002197F0
		public void InitAllRes(USceneComponent Parent, AUIBaseActor DynamicBatchActor, AUIBaseActor HeadStateActor, UCurveFloat ScaleCurve)
		{
			UKSC_HeadStateManager.__InitAllRes_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, (DynamicBatchActor != null) ? DynamicBatchActor.NativePtr : IntPtr.Zero, (HeadStateActor != null) ? HeadStateActor.NativePtr : IntPtr.Zero, (ScaleCurve != null) ? ScaleCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601722E RID: 94766 RVA: 0x0021B64A File Offset: 0x0021984A
		public static UKSC_HeadStateManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_HeadStateManager>(UKSC_HeadStateManager.__GetInstance_Internal());
		}

		// Token: 0x0601722F RID: 94767
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x06017230 RID: 94768 RVA: 0x0021B656 File Offset: 0x00219856
		public static UKSC_HeadStateManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_HeadStateManager>(UKSC_HeadStateManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06017231 RID: 94769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, in float DeltaTime, in FVectorDouble CameraLocation);

		// Token: 0x06017232 RID: 94770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitAllRes_Internal(IntPtr @this, IntPtr Parent, IntPtr DynamicBatchActor, IntPtr HeadStateActor, IntPtr ScaleCurve);

		// Token: 0x06017233 RID: 94771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x06017234 RID: 94772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x06017235 RID: 94773 RVA: 0x0021B672 File Offset: 0x00219872
		static UKSC_HeadStateManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.KSC_HeadStateManager");
		}

		// Token: 0x06017236 RID: 94774 RVA: 0x0021B680 File Offset: 0x00219880
		protected UKSC_HeadStateManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C8C5 RID: 51397
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.KSC_HeadStateManager";

		// Token: 0x0400C8C6 RID: 51398
		private static IntPtr _ClassPtr;

		// Token: 0x0400C8C7 RID: 51399
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C8C8 RID: 51400
		internal static int __PropertyOffset_DynamicBatchView;

		// Token: 0x0400C8C9 RID: 51401
		internal static int __PropertyOffset_KscWorld;
	}
}
