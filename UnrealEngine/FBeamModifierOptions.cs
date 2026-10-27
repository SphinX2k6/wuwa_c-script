using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008A9 RID: 2217
	[UnrealObjectPath("/Script/Engine.BeamModifierOptions")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FBeamModifierOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007943 RID: 31043 RVA: 0x000AD89F File Offset: 0x000ABA9F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBeamModifierOptions._ScriptStructPtr != 0) ? FBeamModifierOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BeamModifierOptions", ref FBeamModifierOptions._ScriptStructPtr);
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06007944 RID: 31044 RVA: 0x000AD8C3 File Offset: 0x000ABAC3
		// (set) Token: 0x06007945 RID: 31045 RVA: 0x000AD8DC File Offset: 0x000ABADC
		public unsafe bool bModify
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bModify) & FBeamModifierOptions.__PropertyMask_bModify) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bModify) = ((*(base.NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bModify) & ~FBeamModifierOptions.__PropertyMask_bModify) | (value ? FBeamModifierOptions.__PropertyMask_bModify : 0));
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06007946 RID: 31046 RVA: 0x000AD90C File Offset: 0x000ABB0C
		// (set) Token: 0x06007947 RID: 31047 RVA: 0x000AD925 File Offset: 0x000ABB25
		public unsafe bool bScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bScale) & FBeamModifierOptions.__PropertyMask_bScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bScale) = ((*(base.NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bScale) & ~FBeamModifierOptions.__PropertyMask_bScale) | (value ? FBeamModifierOptions.__PropertyMask_bScale : 0));
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06007948 RID: 31048 RVA: 0x000AD955 File Offset: 0x000ABB55
		// (set) Token: 0x06007949 RID: 31049 RVA: 0x000AD96E File Offset: 0x000ABB6E
		public unsafe bool bLock
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bLock) & FBeamModifierOptions.__PropertyMask_bLock) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bLock) = ((*(base.NativePtr + (IntPtr)FBeamModifierOptions.__PropertyOffset_bLock) & ~FBeamModifierOptions.__PropertyMask_bLock) | (value ? FBeamModifierOptions.__PropertyMask_bLock : 0));
			}
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x000AD99E File Offset: 0x000ABB9E
		public FBeamModifierOptions()
		{
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x000AD9A6 File Offset: 0x000ABBA6
		public FBeamModifierOptions(bool bModify, bool bScale, bool bLock)
		{
			this.bModify = bModify;
			this.bScale = bScale;
			this.bLock = bLock;
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x000AD9C3 File Offset: 0x000ABBC3
		protected override IntPtr GetUStructPtr()
		{
			return FBeamModifierOptions.StaticStruct();
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x000AD9CF File Offset: 0x000ABBCF
		[NullableContext(2)]
		public FBeamModifierOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x000AD9D9 File Offset: 0x000ABBD9
		public FBeamModifierOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x000AD9E4 File Offset: 0x000ABBE4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBeamModifierOptions(Pointer, false, true);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x000AD9EE File Offset: 0x000ABBEE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBeamModifierOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04003A44 RID: 14916
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BeamModifierOptions";

		// Token: 0x04003A45 RID: 14917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A46 RID: 14918
		internal static int __PropertyOffset_bModify;

		// Token: 0x04003A47 RID: 14919
		internal static byte __PropertyMask_bModify;

		// Token: 0x04003A48 RID: 14920
		internal static int __PropertyOffset_bScale;

		// Token: 0x04003A49 RID: 14921
		internal static byte __PropertyMask_bScale;

		// Token: 0x04003A4A RID: 14922
		internal static int __PropertyOffset_bLock;

		// Token: 0x04003A4B RID: 14923
		internal static byte __PropertyMask_bLock;
	}
}
