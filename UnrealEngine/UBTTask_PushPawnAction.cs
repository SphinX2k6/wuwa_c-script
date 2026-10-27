using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015E RID: 350
	[UnrealObjectPath("/Script/AIModule.BTTask_PushPawnAction")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_PushPawnAction : UBTTask_PawnActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017F0 RID: 6128 RVA: 0x0002342B File Offset: 0x0002162B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_PushPawnAction._ClassPtr;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00023438 File Offset: 0x00021638
		public UBTTask_PushPawnAction() : this(BuiltinUtils.AllocNativeUObject(UBTTask_PushPawnAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00023460 File Offset: 0x00021660
		[NullableContext(1)]
		public UBTTask_PushPawnAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_PushPawnAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00023493 File Offset: 0x00021693
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x000234A7 File Offset: 0x000216A7
		[Nullable(2)]
		public unsafe UPawnAction Action
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PushPawnAction.__PropertyOffset_Action);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PushPawnAction.__PropertyOffset_Action, value);
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x000234BC File Offset: 0x000216BC
		static UBTTask_PushPawnAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_PushPawnAction");
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000234CA File Offset: 0x000216CA
		protected UBTTask_PushPawnAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005DE RID: 1502
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_PushPawnAction";

		// Token: 0x040005DF RID: 1503
		private static IntPtr _ClassPtr;

		// Token: 0x040005E0 RID: 1504
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005E1 RID: 1505
		internal static int __PropertyOffset_Action;
	}
}
