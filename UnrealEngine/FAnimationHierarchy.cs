using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004AD RID: 1197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.AnimationHierarchy")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FAnimationHierarchy : FNodeHierarchyWithUserData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003FA2 RID: 16290 RVA: 0x0005F96E File Offset: 0x0005DB6E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationHierarchy._ScriptStructPtr != 0) ? FAnimationHierarchy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.AnimationHierarchy", ref FAnimationHierarchy._ScriptStructPtr);
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x0005F994 File Offset: 0x0005DB94
		// (set) Token: 0x06003FA4 RID: 16292 RVA: 0x0005F9D7 File Offset: 0x0005DBD7
		public TArray<FConstraintNodeData> UserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConstraintNodeData> result;
				if ((result = this._UserData) == null)
				{
					result = (this._UserData = new TArray<FConstraintNodeData>(base.NativePtr + (IntPtr)FAnimationHierarchy.__PropertyOffset_UserData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UserData.CopyAssign(value);
			}
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x0005F9E5 File Offset: 0x0005DBE5
		public FAnimationHierarchy()
		{
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x0005F9ED File Offset: 0x0005DBED
		public FAnimationHierarchy(TArray<FConstraintNodeData> UserData, FNodeHierarchyData Hierarchy)
		{
			this.UserData = UserData;
			base.Hierarchy = Hierarchy;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x0005FA03 File Offset: 0x0005DC03
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationHierarchy.StaticStruct();
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x0005FA0F File Offset: 0x0005DC0F
		[NullableContext(2)]
		public FAnimationHierarchy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0005FA19 File Offset: 0x0005DC19
		public FAnimationHierarchy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x0005FA24 File Offset: 0x0005DC24
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationHierarchy(Pointer, false, true);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x0005FA2E File Offset: 0x0005DC2E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationHierarchy(Pointer, MemoryOwner);
		}

		// Token: 0x04001E6A RID: 7786
		public new const string __ObjectPath = "/Script/ControlRig.AnimationHierarchy";

		// Token: 0x04001E6B RID: 7787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E6C RID: 7788
		internal static int __PropertyOffset_UserData;

		// Token: 0x04001E6D RID: 7789
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConstraintNodeData> _UserData;
	}
}
