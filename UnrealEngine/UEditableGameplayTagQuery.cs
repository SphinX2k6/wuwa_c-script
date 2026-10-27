using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D1 RID: 5073
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQuery")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UEditableGameplayTagQuery : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012947 RID: 76103 RVA: 0x001B5571 File Offset: 0x001B3771
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQuery._ClassPtr;
		}

		// Token: 0x06012948 RID: 76104 RVA: 0x001B5580 File Offset: 0x001B3780
		public UEditableGameplayTagQuery() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQuery.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012949 RID: 76105 RVA: 0x001B55A8 File Offset: 0x001B37A8
		public UEditableGameplayTagQuery(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x0601294A RID: 76106 RVA: 0x001B55DB File Offset: 0x001B37DB
		// (set) Token: 0x0601294B RID: 76107 RVA: 0x001B55EF File Offset: 0x001B37EF
		public unsafe string UserDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEditableGameplayTagQuery.__PropertyOffset_UserDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEditableGameplayTagQuery.__PropertyOffset_UserDescription)), value);
			}
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x0601294C RID: 76108 RVA: 0x001B5604 File Offset: 0x001B3804
		// (set) Token: 0x0601294D RID: 76109 RVA: 0x001B5618 File Offset: 0x001B3818
		[Nullable(2)]
		public unsafe UEditableGameplayTagQueryExpression RootExpression
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEditableGameplayTagQueryExpression>(base.NativePtr / (IntPtr)sizeof(void*) + UEditableGameplayTagQuery.__PropertyOffset_RootExpression);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEditableGameplayTagQuery.__PropertyOffset_RootExpression, value);
			}
		}

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x0601294E RID: 76110 RVA: 0x001B5630 File Offset: 0x001B3830
		// (set) Token: 0x0601294F RID: 76111 RVA: 0x001B5669 File Offset: 0x001B3869
		public FGameplayTagQuery TagQueryExportText_Helper
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagQuery result;
				if ((result = this._TagQueryExportText_Helper) == null)
				{
					result = (this._TagQueryExportText_Helper = new FGameplayTagQuery(base.NativePtr + (IntPtr)UEditableGameplayTagQuery.__PropertyOffset_TagQueryExportText_Helper, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagQuery.StaticStruct(), base.NativePtr + (IntPtr)UEditableGameplayTagQuery.__PropertyOffset_TagQueryExportText_Helper, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012950 RID: 76112 RVA: 0x001B568A File Offset: 0x001B388A
		static UEditableGameplayTagQuery()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQuery");
		}

		// Token: 0x06012951 RID: 76113 RVA: 0x001B5698 File Offset: 0x001B3898
		protected UEditableGameplayTagQuery(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EC6 RID: 40646
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQuery";

		// Token: 0x04009EC7 RID: 40647
		private static IntPtr _ClassPtr;

		// Token: 0x04009EC8 RID: 40648
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EC9 RID: 40649
		internal static int __PropertyOffset_UserDescription;

		// Token: 0x04009ECA RID: 40650
		internal static int __PropertyOffset_RootExpression;

		// Token: 0x04009ECB RID: 40651
		internal static int __PropertyOffset_TagQueryExportText_Helper;

		// Token: 0x04009ECC RID: 40652
		[Nullable(2)]
		private FGameplayTagQuery _TagQueryExportText_Helper;
	}
}
