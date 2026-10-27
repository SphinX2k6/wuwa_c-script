using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011FE RID: 4606
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TransformBaseConstraint")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FTransformBaseConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010FB8 RID: 69560 RVA: 0x0018EC3C File Offset: 0x0018CE3C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformBaseConstraint._ScriptStructPtr != 0) ? FTransformBaseConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TransformBaseConstraint", ref FTransformBaseConstraint._ScriptStructPtr);
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x06010FB9 RID: 69561 RVA: 0x0018EC60 File Offset: 0x0018CE60
		// (set) Token: 0x06010FBA RID: 69562 RVA: 0x0018ECA3 File Offset: 0x0018CEA3
		public TArray<FRigTransformConstraint> TransformConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigTransformConstraint> result;
				if ((result = this._TransformConstraints) == null)
				{
					result = (this._TransformConstraints = new TArray<FRigTransformConstraint>(base.NativePtr + (IntPtr)FTransformBaseConstraint.__PropertyOffset_TransformConstraints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransformConstraints.CopyAssign(value);
			}
		}

		// Token: 0x06010FBB RID: 69563 RVA: 0x0018ECB1 File Offset: 0x0018CEB1
		public FTransformBaseConstraint()
		{
		}

		// Token: 0x06010FBC RID: 69564 RVA: 0x0018ECB9 File Offset: 0x0018CEB9
		public FTransformBaseConstraint(TArray<FRigTransformConstraint> TransformConstraints)
		{
			this.TransformConstraints = TransformConstraints;
		}

		// Token: 0x06010FBD RID: 69565 RVA: 0x0018ECC8 File Offset: 0x0018CEC8
		protected override IntPtr GetUStructPtr()
		{
			return FTransformBaseConstraint.StaticStruct();
		}

		// Token: 0x06010FBE RID: 69566 RVA: 0x0018ECD4 File Offset: 0x0018CED4
		[NullableContext(2)]
		public FTransformBaseConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010FBF RID: 69567 RVA: 0x0018ECDE File Offset: 0x0018CEDE
		public FTransformBaseConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010FC0 RID: 69568 RVA: 0x0018ECE9 File Offset: 0x0018CEE9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformBaseConstraint(Pointer, false, true);
		}

		// Token: 0x06010FC1 RID: 69569 RVA: 0x0018ECF3 File Offset: 0x0018CEF3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformBaseConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04009180 RID: 37248
		public const string __ObjectPath = "/Script/Engine.TransformBaseConstraint";

		// Token: 0x04009181 RID: 37249
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009182 RID: 37250
		internal static int __PropertyOffset_TransformConstraints;

		// Token: 0x04009183 RID: 37251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigTransformConstraint> _TransformConstraints;
	}
}
