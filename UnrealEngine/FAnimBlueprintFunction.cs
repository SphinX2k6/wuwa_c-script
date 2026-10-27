using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007ED RID: 2029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimBlueprintFunction")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FAnimBlueprintFunction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C3A RID: 27706 RVA: 0x0009B9F0 File Offset: 0x00099BF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimBlueprintFunction._ScriptStructPtr != 0) ? FAnimBlueprintFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimBlueprintFunction", ref FAnimBlueprintFunction._ScriptStructPtr);
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06006C3B RID: 27707 RVA: 0x0009BA14 File Offset: 0x00099C14
		// (set) Token: 0x06006C3C RID: 27708 RVA: 0x0009BA28 File Offset: 0x00099C28
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x0009BA3D File Offset: 0x00099C3D
		// (set) Token: 0x06006C3E RID: 27710 RVA: 0x0009BA51 File Offset: 0x00099C51
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06006C3F RID: 27711 RVA: 0x0009BA66 File Offset: 0x00099C66
		// (set) Token: 0x06006C40 RID: 27712 RVA: 0x0009BA76 File Offset: 0x00099C76
		public unsafe int OutputPoseNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_OutputPoseNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_OutputPoseNodeIndex) = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06006C41 RID: 27713 RVA: 0x0009BA88 File Offset: 0x00099C88
		// (set) Token: 0x06006C42 RID: 27714 RVA: 0x0009BACB File Offset: 0x00099CCB
		public TArray<FName> InputPoseNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InputPoseNames) == null)
				{
					result = (this._InputPoseNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_InputPoseNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputPoseNames.CopyAssign(value);
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06006C43 RID: 27715 RVA: 0x0009BADC File Offset: 0x00099CDC
		// (set) Token: 0x06006C44 RID: 27716 RVA: 0x0009BB1F File Offset: 0x00099D1F
		public TArray<int> InputPoseNodeIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InputPoseNodeIndices) == null)
				{
					result = (this._InputPoseNodeIndices = new TArray<int>(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_InputPoseNodeIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputPoseNodeIndices.CopyAssign(value);
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06006C45 RID: 27717 RVA: 0x0009BB2D File Offset: 0x00099D2D
		// (set) Token: 0x06006C46 RID: 27718 RVA: 0x0009BB3D File Offset: 0x00099D3D
		public unsafe bool bImplemented
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_bImplemented) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimBlueprintFunction.__PropertyOffset_bImplemented) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x0009BB4E File Offset: 0x00099D4E
		public FAnimBlueprintFunction()
		{
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x0009BB56 File Offset: 0x00099D56
		public FAnimBlueprintFunction(FName Name, FName Group, int OutputPoseNodeIndex, TArray<FName> InputPoseNames, TArray<int> InputPoseNodeIndices, bool bImplemented)
		{
			this.Name = Name;
			this.Group = Group;
			this.OutputPoseNodeIndex = OutputPoseNodeIndex;
			this.InputPoseNames = InputPoseNames;
			this.InputPoseNodeIndices = InputPoseNodeIndices;
			this.bImplemented = bImplemented;
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x0009BB8B File Offset: 0x00099D8B
		protected override IntPtr GetUStructPtr()
		{
			return FAnimBlueprintFunction.StaticStruct();
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x0009BB97 File Offset: 0x00099D97
		[NullableContext(2)]
		public FAnimBlueprintFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x0009BBA1 File Offset: 0x00099DA1
		public FAnimBlueprintFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x0009BBAC File Offset: 0x00099DAC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimBlueprintFunction(Pointer, false, true);
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x0009BBB6 File Offset: 0x00099DB6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimBlueprintFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04003413 RID: 13331
		public const string __ObjectPath = "/Script/Engine.AnimBlueprintFunction";

		// Token: 0x04003414 RID: 13332
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003415 RID: 13333
		internal static int __PropertyOffset_Name;

		// Token: 0x04003416 RID: 13334
		internal static int __PropertyOffset_Group;

		// Token: 0x04003417 RID: 13335
		internal static int __PropertyOffset_OutputPoseNodeIndex;

		// Token: 0x04003418 RID: 13336
		internal static int __PropertyOffset_InputPoseNames;

		// Token: 0x04003419 RID: 13337
		[Nullable(2)]
		private TArray<FName> _InputPoseNames;

		// Token: 0x0400341A RID: 13338
		internal static int __PropertyOffset_InputPoseNodeIndices;

		// Token: 0x0400341B RID: 13339
		[Nullable(2)]
		private TArray<int> _InputPoseNodeIndices;

		// Token: 0x0400341C RID: 13340
		internal static int __PropertyOffset_bImplemented;
	}
}
