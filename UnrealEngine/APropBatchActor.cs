using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001810 RID: 6160
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PropBatchActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class APropBatchActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016CA4 RID: 93348 RVA: 0x0021415F File Offset: 0x0021235F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APropBatchActor._ClassPtr;
		}

		// Token: 0x06016CA5 RID: 93349 RVA: 0x0021416C File Offset: 0x0021236C
		public APropBatchActor() : this(BuiltinUtils.AllocNativeUObject(APropBatchActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016CA6 RID: 93350 RVA: 0x00214194 File Offset: 0x00212394
		[NullableContext(1)]
		public APropBatchActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APropBatchActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C0D RID: 23565
		// (get) Token: 0x06016CA7 RID: 93351 RVA: 0x002141C7 File Offset: 0x002123C7
		// (set) Token: 0x06016CA8 RID: 93352 RVA: 0x002141DB File Offset: 0x002123DB
		[Nullable(2)]
		public unsafe UPropBatchComponent PropBatchComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPropBatchComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APropBatchActor.__PropertyOffset_PropBatchComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APropBatchActor.__PropertyOffset_PropBatchComponent, value);
			}
		}

		// Token: 0x06016CA9 RID: 93353 RVA: 0x002141F0 File Offset: 0x002123F0
		public void SetupFromDataAsset()
		{
			APropBatchActor.__SetupFromDataAsset_Internal(base.NativePtr);
		}

		// Token: 0x06016CAA RID: 93354 RVA: 0x002141FD File Offset: 0x002123FD
		public void RefreshProps()
		{
			APropBatchActor.__RefreshProps_Internal(base.NativePtr);
		}

		// Token: 0x06016CAB RID: 93355 RVA: 0x0021420A File Offset: 0x0021240A
		public void ClearAllProps()
		{
			APropBatchActor.__ClearAllProps_Internal(base.NativePtr);
		}

		// Token: 0x06016CAC RID: 93356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupFromDataAsset_Internal(IntPtr @this);

		// Token: 0x06016CAD RID: 93357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshProps_Internal(IntPtr @this);

		// Token: 0x06016CAE RID: 93358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllProps_Internal(IntPtr @this);

		// Token: 0x06016CAF RID: 93359 RVA: 0x00214217 File Offset: 0x00212417
		static APropBatchActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.PropBatchActor");
		}

		// Token: 0x06016CB0 RID: 93360 RVA: 0x00214225 File Offset: 0x00212425
		protected APropBatchActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5D4 RID: 50644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PropBatchActor";

		// Token: 0x0400C5D5 RID: 50645
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5D6 RID: 50646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C5D7 RID: 50647
		internal static int __PropertyOffset_PropBatchComponent;
	}
}
