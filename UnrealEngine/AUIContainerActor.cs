using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002135 RID: 8501
	[UnrealObjectPath("/Script/LGUI.UIContainerActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIContainerActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602001A RID: 131098 RVA: 0x002F9908 File Offset: 0x002F7B08
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIContainerActor._ClassPtr;
		}

		// Token: 0x0602001B RID: 131099 RVA: 0x002F9914 File Offset: 0x002F7B14
		public AUIContainerActor() : this(BuiltinUtils.AllocNativeUObject(AUIContainerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602001C RID: 131100 RVA: 0x002F993C File Offset: 0x002F7B3C
		[NullableContext(1)]
		public AUIContainerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIContainerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DBF RID: 32191
		// (get) Token: 0x0602001D RID: 131101 RVA: 0x002F996F File Offset: 0x002F7B6F
		// (set) Token: 0x0602001E RID: 131102 RVA: 0x002F9983 File Offset: 0x002F7B83
		[Nullable(2)]
		public unsafe UUIItem UIItem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + AUIContainerActor.__PropertyOffset_UIItem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIContainerActor.__PropertyOffset_UIItem, value);
			}
		}

		// Token: 0x0602001F RID: 131103 RVA: 0x002F9998 File Offset: 0x002F7B98
		static AUIContainerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIContainerActor");
		}

		// Token: 0x06020020 RID: 131104 RVA: 0x002F99A6 File Offset: 0x002F7BA6
		protected AUIContainerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113B6 RID: 70582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIContainerActor";

		// Token: 0x040113B7 RID: 70583
		private static IntPtr _ClassPtr;

		// Token: 0x040113B8 RID: 70584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113B9 RID: 70585
		internal static int __PropertyOffset_UIItem;
	}
}
