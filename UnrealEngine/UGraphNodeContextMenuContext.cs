using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C11 RID: 3089
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GraphNodeContextMenuContext")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UGraphNodeContextMenuContext : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C28 RID: 39976 RVA: 0x000DE100 File Offset: 0x000DC300
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGraphNodeContextMenuContext._ClassPtr;
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x000DE10C File Offset: 0x000DC30C
		public UGraphNodeContextMenuContext() : this(BuiltinUtils.AllocNativeUObject(UGraphNodeContextMenuContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x000DE134 File Offset: 0x000DC334
		[NullableContext(1)]
		public UGraphNodeContextMenuContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGraphNodeContextMenuContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x06009C2B RID: 39979 RVA: 0x000DE167 File Offset: 0x000DC367
		// (set) Token: 0x06009C2C RID: 39980 RVA: 0x000DE17B File Offset: 0x000DC37B
		public unsafe UBlueprint Blueprint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlueprint>(base.NativePtr / (IntPtr)sizeof(void*) + UGraphNodeContextMenuContext.__PropertyOffset_Blueprint);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGraphNodeContextMenuContext.__PropertyOffset_Blueprint, value);
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x000DE190 File Offset: 0x000DC390
		// (set) Token: 0x06009C2E RID: 39982 RVA: 0x000DE1A4 File Offset: 0x000DC3A4
		public unsafe UEdGraph Graph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEdGraph>(base.NativePtr / (IntPtr)sizeof(void*) + UGraphNodeContextMenuContext.__PropertyOffset_Graph);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGraphNodeContextMenuContext.__PropertyOffset_Graph, value);
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x000DE1B9 File Offset: 0x000DC3B9
		// (set) Token: 0x06009C30 RID: 39984 RVA: 0x000DE1CD File Offset: 0x000DC3CD
		public unsafe UEdGraphNode Node
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEdGraphNode>(base.NativePtr / (IntPtr)sizeof(void*) + UGraphNodeContextMenuContext.__PropertyOffset_Node);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGraphNodeContextMenuContext.__PropertyOffset_Node, value);
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x06009C31 RID: 39985 RVA: 0x000DE1E2 File Offset: 0x000DC3E2
		// (set) Token: 0x06009C32 RID: 39986 RVA: 0x000DE1F2 File Offset: 0x000DC3F2
		public unsafe bool bIsDebugging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGraphNodeContextMenuContext.__PropertyOffset_bIsDebugging) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGraphNodeContextMenuContext.__PropertyOffset_bIsDebugging) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x000DE203 File Offset: 0x000DC403
		static UGraphNodeContextMenuContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GraphNodeContextMenuContext");
		}

		// Token: 0x06009C34 RID: 39988 RVA: 0x000DE211 File Offset: 0x000DC411
		protected UGraphNodeContextMenuContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005634 RID: 22068
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GraphNodeContextMenuContext";

		// Token: 0x04005635 RID: 22069
		private static IntPtr _ClassPtr;

		// Token: 0x04005636 RID: 22070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005637 RID: 22071
		internal static int __PropertyOffset_Blueprint;

		// Token: 0x04005638 RID: 22072
		internal static int __PropertyOffset_Graph;

		// Token: 0x04005639 RID: 22073
		internal static int __PropertyOffset_Node;

		// Token: 0x0400563A RID: 22074
		internal static int __PropertyOffset_bIsDebugging;
	}
}
