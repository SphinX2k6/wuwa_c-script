using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081D RID: 2077
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_Root")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAnimNode_Root : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006FB0 RID: 28592 RVA: 0x000A049D File Offset: 0x0009E69D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Root._ScriptStructPtr != 0) ? FAnimNode_Root._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_Root", ref FAnimNode_Root._ScriptStructPtr);
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06006FB1 RID: 28593 RVA: 0x000A04C4 File Offset: 0x0009E6C4
		// (set) Token: 0x06006FB2 RID: 28594 RVA: 0x000A0507 File Offset: 0x0009E707
		public FPoseLink Result
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Result) == null)
				{
					result = (this._Result = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_Root.__PropertyOffset_Result, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Root.__PropertyOffset_Result, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06006FB3 RID: 28595 RVA: 0x000A0528 File Offset: 0x0009E728
		// (set) Token: 0x06006FB4 RID: 28596 RVA: 0x000A053C File Offset: 0x0009E73C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Root.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Root.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x000A0551 File Offset: 0x0009E751
		// (set) Token: 0x06006FB6 RID: 28598 RVA: 0x000A0565 File Offset: 0x0009E765
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Root.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Root.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x000A057A File Offset: 0x0009E77A
		public FAnimNode_Root()
		{
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x000A0582 File Offset: 0x0009E782
		public FAnimNode_Root(FPoseLink Result, FName Name, FName Group)
		{
			this.Result = Result;
			this.Name = Name;
			this.Group = Group;
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x000A059F File Offset: 0x0009E79F
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Root.StaticStruct();
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x000A05AB File Offset: 0x0009E7AB
		[NullableContext(2)]
		public FAnimNode_Root(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x000A05B5 File Offset: 0x0009E7B5
		public FAnimNode_Root(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x000A05C0 File Offset: 0x0009E7C0
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Root(Pointer, false, true);
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x000A05CA File Offset: 0x0009E7CA
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Root(Pointer, MemoryOwner);
		}

		// Token: 0x040035AC RID: 13740
		public new const string __ObjectPath = "/Script/Engine.AnimNode_Root";

		// Token: 0x040035AD RID: 13741
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035AE RID: 13742
		internal static int __PropertyOffset_Result;

		// Token: 0x040035AF RID: 13743
		[Nullable(2)]
		private FPoseLink _Result;

		// Token: 0x040035B0 RID: 13744
		internal static int __PropertyOffset_Name;

		// Token: 0x040035B1 RID: 13745
		internal static int __PropertyOffset_Group;
	}
}
