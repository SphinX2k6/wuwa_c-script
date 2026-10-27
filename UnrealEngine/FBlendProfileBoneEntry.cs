using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B1 RID: 2225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlendProfileBoneEntry")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBlendProfileBoneEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007997 RID: 31127 RVA: 0x000ADEFE File Offset: 0x000AC0FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendProfileBoneEntry._ScriptStructPtr != 0) ? FBlendProfileBoneEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlendProfileBoneEntry", ref FBlendProfileBoneEntry._ScriptStructPtr);
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06007998 RID: 31128 RVA: 0x000ADF24 File Offset: 0x000AC124
		// (set) Token: 0x06007999 RID: 31129 RVA: 0x000ADF67 File Offset: 0x000AC167
		public FBoneReference BoneReference
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneReference) == null)
				{
					result = (this._BoneReference = new FBoneReference(base.NativePtr + (IntPtr)FBlendProfileBoneEntry.__PropertyOffset_BoneReference, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBlendProfileBoneEntry.__PropertyOffset_BoneReference, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x000ADF88 File Offset: 0x000AC188
		// (set) Token: 0x0600799B RID: 31131 RVA: 0x000ADF98 File Offset: 0x000AC198
		public unsafe float BlendScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendProfileBoneEntry.__PropertyOffset_BlendScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendProfileBoneEntry.__PropertyOffset_BlendScale) = value;
			}
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x000ADFA9 File Offset: 0x000AC1A9
		public FBlendProfileBoneEntry()
		{
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x000ADFB1 File Offset: 0x000AC1B1
		public FBlendProfileBoneEntry(FBoneReference BoneReference, float BlendScale)
		{
			this.BoneReference = BoneReference;
			this.BlendScale = BlendScale;
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x000ADFC7 File Offset: 0x000AC1C7
		protected override IntPtr GetUStructPtr()
		{
			return FBlendProfileBoneEntry.StaticStruct();
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x000ADFD3 File Offset: 0x000AC1D3
		[NullableContext(2)]
		public FBlendProfileBoneEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x000ADFDD File Offset: 0x000AC1DD
		public FBlendProfileBoneEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x000ADFE8 File Offset: 0x000AC1E8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendProfileBoneEntry(Pointer, false, true);
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x000ADFF2 File Offset: 0x000AC1F2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendProfileBoneEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04003A6E RID: 14958
		public const string __ObjectPath = "/Script/Engine.BlendProfileBoneEntry";

		// Token: 0x04003A6F RID: 14959
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A70 RID: 14960
		internal static int __PropertyOffset_BoneReference;

		// Token: 0x04003A71 RID: 14961
		[Nullable(2)]
		private FBoneReference _BoneReference;

		// Token: 0x04003A72 RID: 14962
		internal static int __PropertyOffset_BlendScale;
	}
}
