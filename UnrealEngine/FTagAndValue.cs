using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E1 RID: 225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AssetRegistry.TagAndValue")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTagAndValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000FC4 RID: 4036 RVA: 0x00019502 File Offset: 0x00017702
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTagAndValue._ScriptStructPtr != 0) ? FTagAndValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AssetRegistry.TagAndValue", ref FTagAndValue._ScriptStructPtr);
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00019526 File Offset: 0x00017726
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0001953A File Offset: 0x0001773A
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTagAndValue.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTagAndValue.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0001954F File Offset: 0x0001774F
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00019563 File Offset: 0x00017763
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTagAndValue.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTagAndValue.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00019578 File Offset: 0x00017778
		public FTagAndValue()
		{
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00019580 File Offset: 0x00017780
		protected override IntPtr GetUStructPtr()
		{
			return FTagAndValue.StaticStruct();
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0001958C File Offset: 0x0001778C
		[NullableContext(2)]
		public FTagAndValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00019596 File Offset: 0x00017796
		public FTagAndValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000195A1 File Offset: 0x000177A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTagAndValue(Pointer, false, true);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000195AB File Offset: 0x000177AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTagAndValue(Pointer, MemoryOwner);
		}

		// Token: 0x04000394 RID: 916
		public const string __ObjectPath = "/Script/AssetRegistry.TagAndValue";

		// Token: 0x04000395 RID: 917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000396 RID: 918
		internal static int __PropertyOffset_Tag;

		// Token: 0x04000397 RID: 919
		internal static int __PropertyOffset_Value;
	}
}
