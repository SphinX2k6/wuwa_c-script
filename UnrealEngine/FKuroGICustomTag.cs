using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B05 RID: 6917
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGICustomTag")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroGICustomTag : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019E78 RID: 106104 RVA: 0x00263C1D File Offset: 0x00261E1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGICustomTag._ScriptStructPtr != 0) ? FKuroGICustomTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGICustomTag", ref FKuroGICustomTag._ScriptStructPtr);
		}

		// Token: 0x170067D0 RID: 26576
		// (get) Token: 0x06019E79 RID: 106105 RVA: 0x00263C41 File Offset: 0x00261E41
		// (set) Token: 0x06019E7A RID: 106106 RVA: 0x00263C55 File Offset: 0x00261E55
		public unsafe FName Property
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGICustomTag.__PropertyOffset_Property);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGICustomTag.__PropertyOffset_Property) = value;
			}
		}

		// Token: 0x170067D1 RID: 26577
		// (get) Token: 0x06019E7B RID: 106107 RVA: 0x00263C6A File Offset: 0x00261E6A
		// (set) Token: 0x06019E7C RID: 106108 RVA: 0x00263C7E File Offset: 0x00261E7E
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGICustomTag.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGICustomTag.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06019E7D RID: 106109 RVA: 0x00263C93 File Offset: 0x00261E93
		public FKuroGICustomTag()
		{
		}

		// Token: 0x06019E7E RID: 106110 RVA: 0x00263C9B File Offset: 0x00261E9B
		public FKuroGICustomTag(FName Property, FLinearColor Value)
		{
			this.Property = Property;
			this.Value = Value;
		}

		// Token: 0x06019E7F RID: 106111 RVA: 0x00263CB1 File Offset: 0x00261EB1
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGICustomTag.StaticStruct();
		}

		// Token: 0x06019E80 RID: 106112 RVA: 0x00263CBD File Offset: 0x00261EBD
		[NullableContext(2)]
		public FKuroGICustomTag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019E81 RID: 106113 RVA: 0x00263CC7 File Offset: 0x00261EC7
		public FKuroGICustomTag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019E82 RID: 106114 RVA: 0x00263CD2 File Offset: 0x00261ED2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGICustomTag(Pointer, false, true);
		}

		// Token: 0x06019E83 RID: 106115 RVA: 0x00263CDC File Offset: 0x00261EDC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGICustomTag(Pointer, MemoryOwner);
		}

		// Token: 0x0400E147 RID: 57671
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGICustomTag";

		// Token: 0x0400E148 RID: 57672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E149 RID: 57673
		internal static int __PropertyOffset_Property;

		// Token: 0x0400E14A RID: 57674
		internal static int __PropertyOffset_Value;
	}
}
