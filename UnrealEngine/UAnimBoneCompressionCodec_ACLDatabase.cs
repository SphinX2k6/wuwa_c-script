using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D0 RID: 208
	[UnrealObjectPath("/Script/ACLPlugin.AnimBoneCompressionCodec_ACLDatabase")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAnimBoneCompressionCodec_ACLDatabase : UAnimBoneCompressionCodec_ACLBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x00019CF6 File Offset: 0x00017EF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBoneCompressionCodec_ACLDatabase._ClassPtr;
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00019D04 File Offset: 0x00017F04
		public UAnimBoneCompressionCodec_ACLDatabase() : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLDatabase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00019D2C File Offset: 0x00017F2C
		[NullableContext(1)]
		public UAnimBoneCompressionCodec_ACLDatabase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBoneCompressionCodec_ACLDatabase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00019D5F File Offset: 0x00017F5F
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x00019D73 File Offset: 0x00017F73
		[Nullable(2)]
		public unsafe UAnimationCompressionLibraryDatabase DatabaseAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationCompressionLibraryDatabase>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBoneCompressionCodec_ACLDatabase.__PropertyOffset_DatabaseAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBoneCompressionCodec_ACLDatabase.__PropertyOffset_DatabaseAsset, value);
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00019D88 File Offset: 0x00017F88
		static UAnimBoneCompressionCodec_ACLDatabase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLDatabase");
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00019D96 File Offset: 0x00017F96
		protected UAnimBoneCompressionCodec_ACLDatabase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400029F RID: 671
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ACLPlugin.AnimBoneCompressionCodec_ACLDatabase";

		// Token: 0x040002A0 RID: 672
		private static IntPtr _ClassPtr;

		// Token: 0x040002A1 RID: 673
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002A2 RID: 674
		internal static int __PropertyOffset_DatabaseAsset;
	}
}
