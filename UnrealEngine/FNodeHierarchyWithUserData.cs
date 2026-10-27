using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C4 RID: 708
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.NodeHierarchyWithUserData")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FNodeHierarchyWithUserData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002745 RID: 10053 RVA: 0x0003AEB6 File Offset: 0x000390B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNodeHierarchyWithUserData._ScriptStructPtr != 0) ? FNodeHierarchyWithUserData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.NodeHierarchyWithUserData", ref FNodeHierarchyWithUserData._ScriptStructPtr);
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x0003AEDC File Offset: 0x000390DC
		// (set) Token: 0x06002747 RID: 10055 RVA: 0x0003AF1F File Offset: 0x0003911F
		public FNodeHierarchyData Hierarchy
		{
			get
			{
				base.FastCheckIsValid();
				FNodeHierarchyData result;
				if ((result = this._Hierarchy) == null)
				{
					result = (this._Hierarchy = new FNodeHierarchyData(base.NativePtr + (IntPtr)FNodeHierarchyWithUserData.__PropertyOffset_Hierarchy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNodeHierarchyData.StaticStruct(), base.NativePtr + (IntPtr)FNodeHierarchyWithUserData.__PropertyOffset_Hierarchy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0003AF40 File Offset: 0x00039140
		public FNodeHierarchyWithUserData()
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0003AF48 File Offset: 0x00039148
		public FNodeHierarchyWithUserData(FNodeHierarchyData Hierarchy)
		{
			this.Hierarchy = Hierarchy;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0003AF57 File Offset: 0x00039157
		protected override IntPtr GetUStructPtr()
		{
			return FNodeHierarchyWithUserData.StaticStruct();
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0003AF63 File Offset: 0x00039163
		[NullableContext(2)]
		public FNodeHierarchyWithUserData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0003AF6D File Offset: 0x0003916D
		public FNodeHierarchyWithUserData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0003AF78 File Offset: 0x00039178
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNodeHierarchyWithUserData(Pointer, false, true);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0003AF82 File Offset: 0x00039182
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNodeHierarchyWithUserData(Pointer, MemoryOwner);
		}

		// Token: 0x04000F7B RID: 3963
		public const string __ObjectPath = "/Script/AnimationCore.NodeHierarchyWithUserData";

		// Token: 0x04000F7C RID: 3964
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F7D RID: 3965
		internal static int __PropertyOffset_Hierarchy;

		// Token: 0x04000F7E RID: 3966
		[Nullable(2)]
		private FNodeHierarchyData _Hierarchy;
	}
}
