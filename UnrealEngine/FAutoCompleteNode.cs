using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000873 RID: 2163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AutoCompleteNode")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAutoCompleteNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007592 RID: 30098 RVA: 0x000A891E File Offset: 0x000A6B1E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutoCompleteNode._ScriptStructPtr != 0) ? FAutoCompleteNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AutoCompleteNode", ref FAutoCompleteNode._ScriptStructPtr);
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06007593 RID: 30099 RVA: 0x000A8942 File Offset: 0x000A6B42
		// (set) Token: 0x06007594 RID: 30100 RVA: 0x000A8952 File Offset: 0x000A6B52
		public unsafe int IndexChar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutoCompleteNode.__PropertyOffset_IndexChar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutoCompleteNode.__PropertyOffset_IndexChar) = value;
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06007595 RID: 30101 RVA: 0x000A8964 File Offset: 0x000A6B64
		// (set) Token: 0x06007596 RID: 30102 RVA: 0x000A89A7 File Offset: 0x000A6BA7
		public TArray<int> AutoCompleteListIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._AutoCompleteListIndices) == null)
				{
					result = (this._AutoCompleteListIndices = new TArray<int>(base.NativePtr + (IntPtr)FAutoCompleteNode.__PropertyOffset_AutoCompleteListIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AutoCompleteListIndices.CopyAssign(value);
			}
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x000A89B5 File Offset: 0x000A6BB5
		public FAutoCompleteNode()
		{
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x000A89BD File Offset: 0x000A6BBD
		public FAutoCompleteNode(int IndexChar, TArray<int> AutoCompleteListIndices)
		{
			this.IndexChar = IndexChar;
			this.AutoCompleteListIndices = AutoCompleteListIndices;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x000A89D3 File Offset: 0x000A6BD3
		protected override IntPtr GetUStructPtr()
		{
			return FAutoCompleteNode.StaticStruct();
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x000A89DF File Offset: 0x000A6BDF
		[NullableContext(2)]
		public FAutoCompleteNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x000A89E9 File Offset: 0x000A6BE9
		public FAutoCompleteNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x000A89F4 File Offset: 0x000A6BF4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutoCompleteNode(Pointer, false, true);
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x000A89FE File Offset: 0x000A6BFE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutoCompleteNode(Pointer, MemoryOwner);
		}

		// Token: 0x0400388D RID: 14477
		public const string __ObjectPath = "/Script/Engine.AutoCompleteNode";

		// Token: 0x0400388E RID: 14478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400388F RID: 14479
		internal static int __PropertyOffset_IndexChar;

		// Token: 0x04003890 RID: 14480
		internal static int __PropertyOffset_AutoCompleteListIndices;

		// Token: 0x04003891 RID: 14481
		[Nullable(2)]
		private TArray<int> _AutoCompleteListIndices;
	}
}
