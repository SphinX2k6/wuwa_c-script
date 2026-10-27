using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001094 RID: 4244
	[UnrealObjectPath("/Script/Engine.RightKneeBoneNames")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FRightKneeBoneNames : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F284 RID: 62084 RVA: 0x00167D87 File Offset: 0x00165F87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRightKneeBoneNames._ScriptStructPtr != 0) ? FRightKneeBoneNames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RightKneeBoneNames", ref FRightKneeBoneNames._ScriptStructPtr);
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0600F285 RID: 62085 RVA: 0x00167DAB File Offset: 0x00165FAB
		// (set) Token: 0x0600F286 RID: 62086 RVA: 0x00167DBF File Offset: 0x00165FBF
		public unsafe FName RightKneeBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRightKneeBoneNames.__PropertyOffset_RightKneeBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRightKneeBoneNames.__PropertyOffset_RightKneeBoneName) = value;
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600F287 RID: 62087 RVA: 0x00167DD4 File Offset: 0x00165FD4
		// (set) Token: 0x0600F288 RID: 62088 RVA: 0x00167DE8 File Offset: 0x00165FE8
		public unsafe FName RightKneeUpBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRightKneeBoneNames.__PropertyOffset_RightKneeUpBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRightKneeBoneNames.__PropertyOffset_RightKneeUpBoneName) = value;
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600F289 RID: 62089 RVA: 0x00167DFD File Offset: 0x00165FFD
		// (set) Token: 0x0600F28A RID: 62090 RVA: 0x00167E11 File Offset: 0x00166011
		public unsafe FName RightKneeDownBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRightKneeBoneNames.__PropertyOffset_RightKneeDownBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRightKneeBoneNames.__PropertyOffset_RightKneeDownBoneName) = value;
			}
		}

		// Token: 0x0600F28B RID: 62091 RVA: 0x00167E26 File Offset: 0x00166026
		public FRightKneeBoneNames()
		{
		}

		// Token: 0x0600F28C RID: 62092 RVA: 0x00167E2E File Offset: 0x0016602E
		public FRightKneeBoneNames(FName RightKneeBoneName, FName RightKneeUpBoneName, FName RightKneeDownBoneName)
		{
			this.RightKneeBoneName = RightKneeBoneName;
			this.RightKneeUpBoneName = RightKneeUpBoneName;
			this.RightKneeDownBoneName = RightKneeDownBoneName;
		}

		// Token: 0x0600F28D RID: 62093 RVA: 0x00167E4B File Offset: 0x0016604B
		protected override IntPtr GetUStructPtr()
		{
			return FRightKneeBoneNames.StaticStruct();
		}

		// Token: 0x0600F28E RID: 62094 RVA: 0x00167E57 File Offset: 0x00166057
		[NullableContext(2)]
		public FRightKneeBoneNames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F28F RID: 62095 RVA: 0x00167E61 File Offset: 0x00166061
		public FRightKneeBoneNames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F290 RID: 62096 RVA: 0x00167E6C File Offset: 0x0016606C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRightKneeBoneNames(Pointer, false, true);
		}

		// Token: 0x0600F291 RID: 62097 RVA: 0x00167E76 File Offset: 0x00166076
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRightKneeBoneNames(Pointer, MemoryOwner);
		}

		// Token: 0x04008397 RID: 33687
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RightKneeBoneNames";

		// Token: 0x04008398 RID: 33688
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008399 RID: 33689
		internal static int __PropertyOffset_RightKneeBoneName;

		// Token: 0x0400839A RID: 33690
		internal static int __PropertyOffset_RightKneeUpBoneName;

		// Token: 0x0400839B RID: 33691
		internal static int __PropertyOffset_RightKneeDownBoneName;
	}
}
