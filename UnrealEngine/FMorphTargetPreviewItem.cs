using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EBC RID: 3772
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MorphTargetPreviewItem")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMorphTargetPreviewItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CC08 RID: 52232 RVA: 0x00129662 File Offset: 0x00127862
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMorphTargetPreviewItem._ScriptStructPtr != 0) ? FMorphTargetPreviewItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MorphTargetPreviewItem", ref FMorphTargetPreviewItem._ScriptStructPtr);
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0600CC09 RID: 52233 RVA: 0x00129686 File Offset: 0x00127886
		// (set) Token: 0x0600CC0A RID: 52234 RVA: 0x0012969A File Offset: 0x0012789A
		public unsafe string MorphName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMorphTargetPreviewItem.__PropertyOffset_MorphName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMorphTargetPreviewItem.__PropertyOffset_MorphName)), value);
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600CC0B RID: 52235 RVA: 0x001296AF File Offset: 0x001278AF
		// (set) Token: 0x0600CC0C RID: 52236 RVA: 0x001296BF File Offset: 0x001278BF
		public unsafe float PreviewValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMorphTargetPreviewItem.__PropertyOffset_PreviewValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMorphTargetPreviewItem.__PropertyOffset_PreviewValue) = value;
			}
		}

		// Token: 0x0600CC0D RID: 52237 RVA: 0x001296D0 File Offset: 0x001278D0
		public FMorphTargetPreviewItem()
		{
		}

		// Token: 0x0600CC0E RID: 52238 RVA: 0x001296D8 File Offset: 0x001278D8
		public FMorphTargetPreviewItem(string MorphName, float PreviewValue)
		{
			this.MorphName = MorphName;
			this.PreviewValue = PreviewValue;
		}

		// Token: 0x0600CC0F RID: 52239 RVA: 0x001296EE File Offset: 0x001278EE
		protected override IntPtr GetUStructPtr()
		{
			return FMorphTargetPreviewItem.StaticStruct();
		}

		// Token: 0x0600CC10 RID: 52240 RVA: 0x001296FA File Offset: 0x001278FA
		[NullableContext(2)]
		public FMorphTargetPreviewItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CC11 RID: 52241 RVA: 0x00129704 File Offset: 0x00127904
		public FMorphTargetPreviewItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CC12 RID: 52242 RVA: 0x0012970F File Offset: 0x0012790F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMorphTargetPreviewItem(Pointer, false, true);
		}

		// Token: 0x0600CC13 RID: 52243 RVA: 0x00129719 File Offset: 0x00127919
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMorphTargetPreviewItem(Pointer, MemoryOwner);
		}

		// Token: 0x04006DF2 RID: 28146
		public const string __ObjectPath = "/Script/Engine.MorphTargetPreviewItem";

		// Token: 0x04006DF3 RID: 28147
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006DF4 RID: 28148
		internal static int __PropertyOffset_MorphName;

		// Token: 0x04006DF5 RID: 28149
		internal static int __PropertyOffset_PreviewValue;
	}
}
