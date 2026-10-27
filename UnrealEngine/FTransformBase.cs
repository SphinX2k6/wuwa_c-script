using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011FD RID: 4605
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TransformBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTransformBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010FAC RID: 69548 RVA: 0x0018EB49 File Offset: 0x0018CD49
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformBase._ScriptStructPtr != 0) ? FTransformBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TransformBase", ref FTransformBase._ScriptStructPtr);
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x06010FAD RID: 69549 RVA: 0x0018EB6D File Offset: 0x0018CD6D
		// (set) Token: 0x06010FAE RID: 69550 RVA: 0x0018EB81 File Offset: 0x0018CD81
		public unsafe FName Node
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformBase.__PropertyOffset_Node);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformBase.__PropertyOffset_Node) = value;
			}
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x06010FAF RID: 69551 RVA: 0x0018EB98 File Offset: 0x0018CD98
		// (set) Token: 0x06010FB0 RID: 69552 RVA: 0x0018EBDC File Offset: 0x0018CDDC
		public TFixedArray<FTransformBaseConstraint> Constraints
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FTransformBaseConstraint> result;
				if ((result = this._Constraints) == null)
				{
					result = (this._Constraints = new TFixedArray<FTransformBaseConstraint>(base.NativePtr + (IntPtr)FTransformBase.__PropertyOffset_Constraints, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Constraints.CopyAssign(value);
			}
		}

		// Token: 0x06010FB1 RID: 69553 RVA: 0x0018EBEA File Offset: 0x0018CDEA
		public FTransformBase()
		{
		}

		// Token: 0x06010FB2 RID: 69554 RVA: 0x0018EBF2 File Offset: 0x0018CDF2
		public FTransformBase(FName Node, TFixedArray<FTransformBaseConstraint> Constraints)
		{
			this.Node = Node;
			this.Constraints = Constraints;
		}

		// Token: 0x06010FB3 RID: 69555 RVA: 0x0018EC08 File Offset: 0x0018CE08
		protected override IntPtr GetUStructPtr()
		{
			return FTransformBase.StaticStruct();
		}

		// Token: 0x06010FB4 RID: 69556 RVA: 0x0018EC14 File Offset: 0x0018CE14
		[NullableContext(2)]
		public FTransformBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010FB5 RID: 69557 RVA: 0x0018EC1E File Offset: 0x0018CE1E
		public FTransformBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010FB6 RID: 69558 RVA: 0x0018EC29 File Offset: 0x0018CE29
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformBase(Pointer, false, true);
		}

		// Token: 0x06010FB7 RID: 69559 RVA: 0x0018EC33 File Offset: 0x0018CE33
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400917B RID: 37243
		public const string __ObjectPath = "/Script/Engine.TransformBase";

		// Token: 0x0400917C RID: 37244
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400917D RID: 37245
		internal static int __PropertyOffset_Node;

		// Token: 0x0400917E RID: 37246
		internal static int __PropertyOffset_Constraints;

		// Token: 0x0400917F RID: 37247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FTransformBaseConstraint> _Constraints;
	}
}
