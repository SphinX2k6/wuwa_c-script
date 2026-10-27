using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B1 RID: 4785
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldSystemActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AFieldSystemActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011868 RID: 71784 RVA: 0x0019B7A6 File Offset: 0x001999A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AFieldSystemActor._ClassPtr;
		}

		// Token: 0x06011869 RID: 71785 RVA: 0x0019B7B4 File Offset: 0x001999B4
		public AFieldSystemActor() : this(BuiltinUtils.AllocNativeUObject(AFieldSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601186A RID: 71786 RVA: 0x0019B7DC File Offset: 0x001999DC
		[NullableContext(1)]
		public AFieldSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AFieldSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x0601186B RID: 71787 RVA: 0x0019B80F File Offset: 0x00199A0F
		// (set) Token: 0x0601186C RID: 71788 RVA: 0x0019B823 File Offset: 0x00199A23
		[Nullable(2)]
		public unsafe UFieldSystemComponent FieldSystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFieldSystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AFieldSystemActor.__PropertyOffset_FieldSystemComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AFieldSystemActor.__PropertyOffset_FieldSystemComponent, value);
			}
		}

		// Token: 0x0601186D RID: 71789 RVA: 0x0019B838 File Offset: 0x00199A38
		static AFieldSystemActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldSystemActor");
		}

		// Token: 0x0601186E RID: 71790 RVA: 0x0019B846 File Offset: 0x00199A46
		protected AFieldSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009641 RID: 38465
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldSystemActor";

		// Token: 0x04009642 RID: 38466
		private static IntPtr _ClassPtr;

		// Token: 0x04009643 RID: 38467
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009644 RID: 38468
		internal static int __PropertyOffset_FieldSystemComponent;
	}
}
