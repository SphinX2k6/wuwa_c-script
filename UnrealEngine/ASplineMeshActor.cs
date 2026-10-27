using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200117A RID: 4474
	[UnrealObjectPath("/Script/Engine.SplineMeshActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ASplineMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060106BF RID: 67263 RVA: 0x001820F8 File Offset: 0x001802F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASplineMeshActor._ClassPtr;
		}

		// Token: 0x060106C0 RID: 67264 RVA: 0x00182104 File Offset: 0x00180304
		public ASplineMeshActor() : this(BuiltinUtils.AllocNativeUObject(ASplineMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060106C1 RID: 67265 RVA: 0x0018212C File Offset: 0x0018032C
		[NullableContext(1)]
		public ASplineMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASplineMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x060106C2 RID: 67266 RVA: 0x0018215F File Offset: 0x0018035F
		// (set) Token: 0x060106C3 RID: 67267 RVA: 0x00182173 File Offset: 0x00180373
		[Nullable(2)]
		public unsafe USplineMeshComponent SplineMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASplineMeshActor.__PropertyOffset_SplineMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASplineMeshActor.__PropertyOffset_SplineMeshComponent, value);
			}
		}

		// Token: 0x060106C4 RID: 67268 RVA: 0x00182188 File Offset: 0x00180388
		static ASplineMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SplineMeshActor");
		}

		// Token: 0x060106C5 RID: 67269 RVA: 0x00182196 File Offset: 0x00180396
		protected ASplineMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008CAA RID: 36010
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineMeshActor";

		// Token: 0x04008CAB RID: 36011
		private static IntPtr _ClassPtr;

		// Token: 0x04008CAC RID: 36012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008CAD RID: 36013
		internal static int __PropertyOffset_SplineMeshComponent;
	}
}
