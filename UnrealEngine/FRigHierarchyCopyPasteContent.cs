using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000523 RID: 1315
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigHierarchyCopyPasteContent")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigHierarchyCopyPasteContent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044F0 RID: 17648 RVA: 0x00066A22 File Offset: 0x00064C22
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigHierarchyCopyPasteContent._ScriptStructPtr != 0) ? FRigHierarchyCopyPasteContent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigHierarchyCopyPasteContent", ref FRigHierarchyCopyPasteContent._ScriptStructPtr);
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x00066A48 File Offset: 0x00064C48
		// (set) Token: 0x060044F2 RID: 17650 RVA: 0x00066A8B File Offset: 0x00064C8B
		public TArray<ERigElementType> Types
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ERigElementType> result;
				if ((result = this._Types) == null)
				{
					result = (this._Types = new TArray<ERigElementType>(base.NativePtr + (IntPtr)FRigHierarchyCopyPasteContent.__PropertyOffset_Types, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Types.CopyAssign(value);
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x00066A9C File Offset: 0x00064C9C
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x00066ADF File Offset: 0x00064CDF
		public TArray<string> Contents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Contents) == null)
				{
					result = (this._Contents = new TArray<string>(base.NativePtr + (IntPtr)FRigHierarchyCopyPasteContent.__PropertyOffset_Contents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Contents.CopyAssign(value);
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x00066AF0 File Offset: 0x00064CF0
		// (set) Token: 0x060044F6 RID: 17654 RVA: 0x00066B33 File Offset: 0x00064D33
		public TArray<FTransform> LocalTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._LocalTransforms) == null)
				{
					result = (this._LocalTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigHierarchyCopyPasteContent.__PropertyOffset_LocalTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalTransforms.CopyAssign(value);
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x00066B44 File Offset: 0x00064D44
		// (set) Token: 0x060044F8 RID: 17656 RVA: 0x00066B87 File Offset: 0x00064D87
		public TArray<FTransform> GlobalTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._GlobalTransforms) == null)
				{
					result = (this._GlobalTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigHierarchyCopyPasteContent.__PropertyOffset_GlobalTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GlobalTransforms.CopyAssign(value);
			}
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00066B95 File Offset: 0x00064D95
		public FRigHierarchyCopyPasteContent()
		{
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00066B9D File Offset: 0x00064D9D
		public FRigHierarchyCopyPasteContent(TArray<ERigElementType> Types, TArray<string> Contents, TArray<FTransform> LocalTransforms, TArray<FTransform> GlobalTransforms)
		{
			this.Types = Types;
			this.Contents = Contents;
			this.LocalTransforms = LocalTransforms;
			this.GlobalTransforms = GlobalTransforms;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00066BC2 File Offset: 0x00064DC2
		protected override IntPtr GetUStructPtr()
		{
			return FRigHierarchyCopyPasteContent.StaticStruct();
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00066BCE File Offset: 0x00064DCE
		[NullableContext(2)]
		public FRigHierarchyCopyPasteContent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00066BD8 File Offset: 0x00064DD8
		public FRigHierarchyCopyPasteContent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00066BE3 File Offset: 0x00064DE3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigHierarchyCopyPasteContent(Pointer, false, true);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00066BED File Offset: 0x00064DED
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigHierarchyCopyPasteContent(Pointer, MemoryOwner);
		}

		// Token: 0x04002194 RID: 8596
		public const string __ObjectPath = "/Script/ControlRig.RigHierarchyCopyPasteContent";

		// Token: 0x04002195 RID: 8597
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002196 RID: 8598
		internal static int __PropertyOffset_Types;

		// Token: 0x04002197 RID: 8599
		[Nullable(2)]
		private TArray<ERigElementType> _Types;

		// Token: 0x04002198 RID: 8600
		internal static int __PropertyOffset_Contents;

		// Token: 0x04002199 RID: 8601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Contents;

		// Token: 0x0400219A RID: 8602
		internal static int __PropertyOffset_LocalTransforms;

		// Token: 0x0400219B RID: 8603
		[Nullable(2)]
		private TArray<FTransform> _LocalTransforms;

		// Token: 0x0400219C RID: 8604
		internal static int __PropertyOffset_GlobalTransforms;

		// Token: 0x0400219D RID: 8605
		[Nullable(2)]
		private TArray<FTransform> _GlobalTransforms;
	}
}
