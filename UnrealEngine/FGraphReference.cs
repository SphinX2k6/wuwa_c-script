using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C12 RID: 3090
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GraphReference")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGraphReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009C35 RID: 39989 RVA: 0x000DE21A File Offset: 0x000DC41A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGraphReference._ScriptStructPtr != 0) ? FGraphReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GraphReference", ref FGraphReference._ScriptStructPtr);
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x000DE23E File Offset: 0x000DC43E
		// (set) Token: 0x06009C37 RID: 39991 RVA: 0x000DE252 File Offset: 0x000DC452
		public unsafe UEdGraph MacroGraph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEdGraph>(base.NativePtr / (IntPtr)sizeof(void*) + FGraphReference.__PropertyOffset_MacroGraph);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGraphReference.__PropertyOffset_MacroGraph, value);
			}
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x06009C38 RID: 39992 RVA: 0x000DE267 File Offset: 0x000DC467
		// (set) Token: 0x06009C39 RID: 39993 RVA: 0x000DE27B File Offset: 0x000DC47B
		public unsafe UBlueprint GraphBlueprint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlueprint>(base.NativePtr / (IntPtr)sizeof(void*) + FGraphReference.__PropertyOffset_GraphBlueprint);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGraphReference.__PropertyOffset_GraphBlueprint, value);
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x000DE290 File Offset: 0x000DC490
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x000DE2A4 File Offset: 0x000DC4A4
		public unsafe FGuid GraphGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGraphReference.__PropertyOffset_GraphGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGraphReference.__PropertyOffset_GraphGuid) = value;
			}
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x000DE2B9 File Offset: 0x000DC4B9
		public FGraphReference()
		{
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x000DE2C1 File Offset: 0x000DC4C1
		[NullableContext(1)]
		public FGraphReference(UEdGraph MacroGraph, UBlueprint GraphBlueprint, FGuid GraphGuid)
		{
			this.MacroGraph = MacroGraph;
			this.GraphBlueprint = GraphBlueprint;
			this.GraphGuid = GraphGuid;
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x000DE2DE File Offset: 0x000DC4DE
		protected override IntPtr GetUStructPtr()
		{
			return FGraphReference.StaticStruct();
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x000DE2EA File Offset: 0x000DC4EA
		public FGraphReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x000DE2F4 File Offset: 0x000DC4F4
		public FGraphReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x000DE2FF File Offset: 0x000DC4FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGraphReference(Pointer, false, true);
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x000DE309 File Offset: 0x000DC509
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGraphReference(Pointer, MemoryOwner);
		}

		// Token: 0x0400563B RID: 22075
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.GraphReference";

		// Token: 0x0400563C RID: 22076
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400563D RID: 22077
		internal static int __PropertyOffset_MacroGraph;

		// Token: 0x0400563E RID: 22078
		internal static int __PropertyOffset_GraphBlueprint;

		// Token: 0x0400563F RID: 22079
		internal static int __PropertyOffset_GraphGuid;
	}
}
