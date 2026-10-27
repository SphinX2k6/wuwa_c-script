using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001058 RID: 4184
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigVertexInputElement")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPSOGeneratorConfigVertexInputElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDFC RID: 60924 RVA: 0x0016131C File Offset: 0x0015F51C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigVertexInputElement._ScriptStructPtr != 0) ? FPSOGeneratorConfigVertexInputElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigVertexInputElement", ref FPSOGeneratorConfigVertexInputElement._ScriptStructPtr);
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600EDFD RID: 60925 RVA: 0x00161340 File Offset: 0x0015F540
		// (set) Token: 0x0600EDFE RID: 60926 RVA: 0x00161354 File Offset: 0x0015F554
		[Nullable(1)]
		public unsafe string Name
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Name)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600EDFF RID: 60927 RVA: 0x00161369 File Offset: 0x0015F569
		// (set) Token: 0x0600EE00 RID: 60928 RVA: 0x00161379 File Offset: 0x0015F579
		public unsafe byte StreamIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_StreamIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_StreamIndex) = value;
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0016138A File Offset: 0x0015F58A
		// (set) Token: 0x0600EE02 RID: 60930 RVA: 0x0016139A File Offset: 0x0015F59A
		public unsafe byte Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600EE03 RID: 60931 RVA: 0x001613AB File Offset: 0x0015F5AB
		// (set) Token: 0x0600EE04 RID: 60932 RVA: 0x001613BF File Offset: 0x0015F5BF
		public unsafe TEnumAsByte<EPSOGeneratorVertexElementType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600EE05 RID: 60933 RVA: 0x001613D4 File Offset: 0x0015F5D4
		// (set) Token: 0x0600EE06 RID: 60934 RVA: 0x001613E4 File Offset: 0x0015F5E4
		public unsafe byte AttributeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_AttributeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_AttributeIndex) = value;
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600EE07 RID: 60935 RVA: 0x001613F5 File Offset: 0x0015F5F5
		// (set) Token: 0x0600EE08 RID: 60936 RVA: 0x00161405 File Offset: 0x0015F605
		public unsafe ushort Stride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Stride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_Stride) = (short)value;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600EE09 RID: 60937 RVA: 0x00161416 File Offset: 0x0015F616
		// (set) Token: 0x0600EE0A RID: 60938 RVA: 0x00161426 File Offset: 0x0015F626
		public unsafe ushort bUseInstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_bUseInstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInputElement.__PropertyOffset_bUseInstanceIndex) = (short)value;
			}
		}

		// Token: 0x0600EE0B RID: 60939 RVA: 0x00161437 File Offset: 0x0015F637
		public FPSOGeneratorConfigVertexInputElement()
		{
		}

		// Token: 0x0600EE0C RID: 60940 RVA: 0x0016143F File Offset: 0x0015F63F
		public FPSOGeneratorConfigVertexInputElement([Nullable(1)] string Name, byte StreamIndex, byte Offset, TEnumAsByte<EPSOGeneratorVertexElementType> Type, byte AttributeIndex, ushort Stride, ushort bUseInstanceIndex)
		{
			this.Name = Name;
			this.StreamIndex = StreamIndex;
			this.Offset = Offset;
			this.Type = Type;
			this.AttributeIndex = AttributeIndex;
			this.Stride = Stride;
			this.bUseInstanceIndex = bUseInstanceIndex;
		}

		// Token: 0x0600EE0D RID: 60941 RVA: 0x0016147C File Offset: 0x0015F67C
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigVertexInputElement.StaticStruct();
		}

		// Token: 0x0600EE0E RID: 60942 RVA: 0x00161488 File Offset: 0x0015F688
		[NullableContext(2)]
		public FPSOGeneratorConfigVertexInputElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE0F RID: 60943 RVA: 0x00161492 File Offset: 0x0015F692
		public FPSOGeneratorConfigVertexInputElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE10 RID: 60944 RVA: 0x0016149D File Offset: 0x0015F69D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigVertexInputElement(Pointer, false, true);
		}

		// Token: 0x0600EE11 RID: 60945 RVA: 0x001614A7 File Offset: 0x0015F6A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigVertexInputElement(Pointer, MemoryOwner);
		}

		// Token: 0x040080E1 RID: 32993
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigVertexInputElement";

		// Token: 0x040080E2 RID: 32994
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080E3 RID: 32995
		internal static int __PropertyOffset_Name;

		// Token: 0x040080E4 RID: 32996
		internal static int __PropertyOffset_StreamIndex;

		// Token: 0x040080E5 RID: 32997
		internal static int __PropertyOffset_Offset;

		// Token: 0x040080E6 RID: 32998
		internal static int __PropertyOffset_Type;

		// Token: 0x040080E7 RID: 32999
		internal static int __PropertyOffset_AttributeIndex;

		// Token: 0x040080E8 RID: 33000
		internal static int __PropertyOffset_Stride;

		// Token: 0x040080E9 RID: 33001
		internal static int __PropertyOffset_bUseInstanceIndex;
	}
}
