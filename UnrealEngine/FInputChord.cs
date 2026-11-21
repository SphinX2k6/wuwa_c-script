using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081E RID: 2078
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Slate.InputChord")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FInputChord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5E3 RID: 46563 RVA: 0x001214F1 File Offset: 0x0011F6F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputChord._ScriptStructPtr != 0) ? FInputChord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.InputChord", ref FInputChord._ScriptStructPtr);
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600B5E4 RID: 46564 RVA: 0x00121518 File Offset: 0x0011F718
		// (set) Token: 0x0600B5E5 RID: 46565 RVA: 0x0012155B File Offset: 0x0011F75B
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x0012157C File Offset: 0x0011F77C
		// (set) Token: 0x0600B5E7 RID: 46567 RVA: 0x00121595 File Offset: 0x0011F795
		public unsafe bool bShift
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bShift) & FInputChord.__PropertyMask_bShift) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bShift) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bShift) & ~FInputChord.__PropertyMask_bShift) | (value ? FInputChord.__PropertyMask_bShift : 0));
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600B5E8 RID: 46568 RVA: 0x001215C5 File Offset: 0x0011F7C5
		// (set) Token: 0x0600B5E9 RID: 46569 RVA: 0x001215DE File Offset: 0x0011F7DE
		public unsafe bool bCtrl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCtrl) & FInputChord.__PropertyMask_bCtrl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCtrl) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCtrl) & ~FInputChord.__PropertyMask_bCtrl) | (value ? FInputChord.__PropertyMask_bCtrl : 0));
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x0600B5EA RID: 46570 RVA: 0x0012160E File Offset: 0x0011F80E
		// (set) Token: 0x0600B5EB RID: 46571 RVA: 0x00121627 File Offset: 0x0011F827
		public unsafe bool bAlt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bAlt) & FInputChord.__PropertyMask_bAlt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bAlt) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bAlt) & ~FInputChord.__PropertyMask_bAlt) | (value ? FInputChord.__PropertyMask_bAlt : 0));
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x0600B5EC RID: 46572 RVA: 0x00121657 File Offset: 0x0011F857
		// (set) Token: 0x0600B5ED RID: 46573 RVA: 0x00121670 File Offset: 0x0011F870
		public unsafe bool bCmd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCmd) & FInputChord.__PropertyMask_bCmd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCmd) = ((*(base.NativePtr + (IntPtr)FInputChord.__PropertyOffset_bCmd) & ~FInputChord.__PropertyMask_bCmd) | (value ? FInputChord.__PropertyMask_bCmd : 0));
			}
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x001216A0 File Offset: 0x0011F8A0
		public FInputChord()
		{
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x001216A8 File Offset: 0x0011F8A8
		protected override IntPtr GetUStructPtr()
		{
			return FInputChord.StaticStruct();
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x001216B4 File Offset: 0x0011F8B4
		[NullableContext(2)]
		public FInputChord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x001216BE File Offset: 0x0011F8BE
		public FInputChord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5F2 RID: 46578 RVA: 0x001216C9 File Offset: 0x0011F8C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputChord(Pointer, false, true);
		}

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x001216D3 File Offset: 0x0011F8D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputChord(Pointer, MemoryOwner);
		}

		// Token: 0x04005228 RID: 21032
		public const string __ObjectPath = "/Script/Slate.InputChord";

		// Token: 0x04005229 RID: 21033
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400522A RID: 21034
		internal static int __PropertyOffset_Key;

		// Token: 0x0400522B RID: 21035
		[Nullable(2)]
		private FKey _Key;

		// Token: 0x0400522C RID: 21036
		internal static int __PropertyOffset_bShift;

		// Token: 0x0400522D RID: 21037
		internal static byte __PropertyMask_bShift;

		// Token: 0x0400522E RID: 21038
		internal static int __PropertyOffset_bCtrl;

		// Token: 0x0400522F RID: 21039
		internal static byte __PropertyMask_bCtrl;

		// Token: 0x04005230 RID: 21040
		internal static int __PropertyOffset_bAlt;

		// Token: 0x04005231 RID: 21041
		internal static byte __PropertyMask_bAlt;

		// Token: 0x04005232 RID: 21042
		internal static int __PropertyOffset_bCmd;

		// Token: 0x04005233 RID: 21043
		internal static byte __PropertyMask_bCmd;
	}
}
