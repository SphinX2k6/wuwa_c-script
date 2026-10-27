using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F0 RID: 240
	[UnrealObjectPath("/Script/AIModule.AIMoveRequest")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAIMoveRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012D4 RID: 4820 RVA: 0x0001BEBE File Offset: 0x0001A0BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIMoveRequest._ScriptStructPtr != 0) ? FAIMoveRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIMoveRequest", ref FAIMoveRequest._ScriptStructPtr);
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0001BEE2 File Offset: 0x0001A0E2
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0001BEF6 File Offset: 0x0001A0F6
		[Nullable(2)]
		public unsafe AActor GoalActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAIMoveRequest.__PropertyOffset_GoalActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAIMoveRequest.__PropertyOffset_GoalActor, value);
			}
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0001BF0B File Offset: 0x0001A10B
		public FAIMoveRequest()
		{
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0001BF13 File Offset: 0x0001A113
		[NullableContext(1)]
		public FAIMoveRequest(AActor GoalActor)
		{
			this.GoalActor = GoalActor;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0001BF22 File Offset: 0x0001A122
		protected override IntPtr GetUStructPtr()
		{
			return FAIMoveRequest.StaticStruct();
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0001BF2E File Offset: 0x0001A12E
		[NullableContext(2)]
		public FAIMoveRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0001BF38 File Offset: 0x0001A138
		public FAIMoveRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0001BF43 File Offset: 0x0001A143
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIMoveRequest(Pointer, false, true);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0001BF4D File Offset: 0x0001A14D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIMoveRequest(Pointer, MemoryOwner);
		}

		// Token: 0x04000350 RID: 848
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIMoveRequest";

		// Token: 0x04000351 RID: 849
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000352 RID: 850
		internal static int __PropertyOffset_GoalActor;
	}
}
