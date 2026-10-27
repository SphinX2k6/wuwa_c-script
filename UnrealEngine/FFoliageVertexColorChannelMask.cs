using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012CC RID: 4812
	[UnrealObjectPath("/Script/Foliage.FoliageVertexColorChannelMask")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FFoliageVertexColorChannelMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011A84 RID: 72324 RVA: 0x0019EAC3 File Offset: 0x0019CCC3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoliageVertexColorChannelMask._ScriptStructPtr != 0) ? FFoliageVertexColorChannelMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Foliage.FoliageVertexColorChannelMask", ref FFoliageVertexColorChannelMask._ScriptStructPtr);
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x06011A85 RID: 72325 RVA: 0x0019EAE7 File Offset: 0x0019CCE7
		// (set) Token: 0x06011A86 RID: 72326 RVA: 0x0019EB00 File Offset: 0x0019CD00
		public unsafe bool UseMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_UseMask) & FFoliageVertexColorChannelMask.__PropertyMask_UseMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_UseMask) = ((*(base.NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_UseMask) & ~FFoliageVertexColorChannelMask.__PropertyMask_UseMask) | (value ? FFoliageVertexColorChannelMask.__PropertyMask_UseMask : 0));
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x06011A87 RID: 72327 RVA: 0x0019EB30 File Offset: 0x0019CD30
		// (set) Token: 0x06011A88 RID: 72328 RVA: 0x0019EB40 File Offset: 0x0019CD40
		public unsafe float MaskThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_MaskThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_MaskThreshold) = value;
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x06011A89 RID: 72329 RVA: 0x0019EB51 File Offset: 0x0019CD51
		// (set) Token: 0x06011A8A RID: 72330 RVA: 0x0019EB6A File Offset: 0x0019CD6A
		public unsafe bool InvertMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_InvertMask) & FFoliageVertexColorChannelMask.__PropertyMask_InvertMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_InvertMask) = ((*(base.NativePtr + (IntPtr)FFoliageVertexColorChannelMask.__PropertyOffset_InvertMask) & ~FFoliageVertexColorChannelMask.__PropertyMask_InvertMask) | (value ? FFoliageVertexColorChannelMask.__PropertyMask_InvertMask : 0));
			}
		}

		// Token: 0x06011A8B RID: 72331 RVA: 0x0019EB9A File Offset: 0x0019CD9A
		public FFoliageVertexColorChannelMask()
		{
		}

		// Token: 0x06011A8C RID: 72332 RVA: 0x0019EBA2 File Offset: 0x0019CDA2
		public FFoliageVertexColorChannelMask(bool UseMask, float MaskThreshold, bool InvertMask)
		{
			this.UseMask = UseMask;
			this.MaskThreshold = MaskThreshold;
			this.InvertMask = InvertMask;
		}

		// Token: 0x06011A8D RID: 72333 RVA: 0x0019EBBF File Offset: 0x0019CDBF
		protected override IntPtr GetUStructPtr()
		{
			return FFoliageVertexColorChannelMask.StaticStruct();
		}

		// Token: 0x06011A8E RID: 72334 RVA: 0x0019EBCB File Offset: 0x0019CDCB
		[NullableContext(2)]
		public FFoliageVertexColorChannelMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011A8F RID: 72335 RVA: 0x0019EBD5 File Offset: 0x0019CDD5
		public FFoliageVertexColorChannelMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011A90 RID: 72336 RVA: 0x0019EBE0 File Offset: 0x0019CDE0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoliageVertexColorChannelMask(Pointer, false, true);
		}

		// Token: 0x06011A91 RID: 72337 RVA: 0x0019EBEA File Offset: 0x0019CDEA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoliageVertexColorChannelMask(Pointer, MemoryOwner);
		}

		// Token: 0x0400978A RID: 38794
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Foliage.FoliageVertexColorChannelMask";

		// Token: 0x0400978B RID: 38795
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400978C RID: 38796
		internal static int __PropertyOffset_UseMask;

		// Token: 0x0400978D RID: 38797
		internal static byte __PropertyMask_UseMask;

		// Token: 0x0400978E RID: 38798
		internal static int __PropertyOffset_MaskThreshold;

		// Token: 0x0400978F RID: 38799
		internal static int __PropertyOffset_InvertMask;

		// Token: 0x04009790 RID: 38800
		internal static byte __PropertyMask_InvertMask;
	}
}
