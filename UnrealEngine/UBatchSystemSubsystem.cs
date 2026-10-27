using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200180D RID: 6157
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.BatchSystemSubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UBatchSystemSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016C8A RID: 93322 RVA: 0x00213F59 File Offset: 0x00212159
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBatchSystemSubsystem._ClassPtr;
		}

		// Token: 0x06016C8B RID: 93323 RVA: 0x00213F68 File Offset: 0x00212168
		public UBatchSystemSubsystem() : this(BuiltinUtils.AllocNativeUObject(UBatchSystemSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016C8C RID: 93324 RVA: 0x00213F90 File Offset: 0x00212190
		[NullableContext(1)]
		public UBatchSystemSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBatchSystemSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C0A RID: 23562
		// (get) Token: 0x06016C8D RID: 93325 RVA: 0x00213FC3 File Offset: 0x002121C3
		// (set) Token: 0x06016C8E RID: 93326 RVA: 0x00213FD7 File Offset: 0x002121D7
		[Nullable(2)]
		public unsafe ABatchSystem BatchSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABatchSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UBatchSystemSubsystem.__PropertyOffset_BatchSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBatchSystemSubsystem.__PropertyOffset_BatchSystem, value);
			}
		}

		// Token: 0x06016C8F RID: 93327 RVA: 0x00213FEC File Offset: 0x002121EC
		static UBatchSystemSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.BatchSystemSubsystem");
		}

		// Token: 0x06016C90 RID: 93328 RVA: 0x00213FFA File Offset: 0x002121FA
		protected UBatchSystemSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5C9 RID: 50633
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.BatchSystemSubsystem";

		// Token: 0x0400C5CA RID: 50634
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5CB RID: 50635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C5CC RID: 50636
		internal static int __PropertyOffset_BatchSystem;
	}
}
