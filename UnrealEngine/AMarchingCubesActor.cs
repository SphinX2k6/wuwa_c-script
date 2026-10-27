using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D72 RID: 3442
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MarchingCubesActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AMarchingCubesActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B9E1 RID: 47585 RVA: 0x00108662 File Offset: 0x00106862
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMarchingCubesActor._ClassPtr;
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x00108670 File Offset: 0x00106870
		public AMarchingCubesActor() : this(BuiltinUtils.AllocNativeUObject(AMarchingCubesActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x00108698 File Offset: 0x00106898
		[NullableContext(1)]
		public AMarchingCubesActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMarchingCubesActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x001086CB File Offset: 0x001068CB
		// (set) Token: 0x0600B9E5 RID: 47589 RVA: 0x001086DF File Offset: 0x001068DF
		public unsafe UMarchingCubesComponent MarchingCubesComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMarchingCubesComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AMarchingCubesActor.__PropertyOffset_MarchingCubesComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AMarchingCubesActor.__PropertyOffset_MarchingCubesComponent, value);
			}
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x001086F4 File Offset: 0x001068F4
		public UMarchingCubesComponent GetMarchingCubesComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMarchingCubesComponent>(AMarchingCubesActor.__GetMarchingCubesComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600B9E7 RID: 47591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMarchingCubesComponent_Internal(IntPtr @this);

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x00108706 File Offset: 0x00106906
		static AMarchingCubesActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MarchingCubesActor");
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x00108714 File Offset: 0x00106914
		protected AMarchingCubesActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400615C RID: 24924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MarchingCubesActor";

		// Token: 0x0400615D RID: 24925
		private static IntPtr _ClassPtr;

		// Token: 0x0400615E RID: 24926
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400615F RID: 24927
		internal static int __PropertyOffset_MarchingCubesComponent;
	}
}
