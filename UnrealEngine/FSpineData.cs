using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002711 RID: 10001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.SpineData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSpineData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602513D RID: 151869 RVA: 0x0036E7CE File Offset: 0x0036C9CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineData._ScriptStructPtr != 0) ? FSpineData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.SpineData", ref FSpineData._ScriptStructPtr);
		}

		// Token: 0x17008F0B RID: 36619
		// (get) Token: 0x0602513E RID: 151870 RVA: 0x0036E7F2 File Offset: 0x0036C9F2
		// (set) Token: 0x0602513F RID: 151871 RVA: 0x0036E806 File Offset: 0x0036CA06
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpineData.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpineData.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17008F0C RID: 36620
		// (get) Token: 0x06025140 RID: 151872 RVA: 0x0036E81B File Offset: 0x0036CA1B
		// (set) Token: 0x06025141 RID: 151873 RVA: 0x0036E82B File Offset: 0x0036CA2B
		public unsafe bool NeedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineData.__PropertyOffset_NeedLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineData.__PropertyOffset_NeedLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025142 RID: 151874 RVA: 0x0036E83C File Offset: 0x0036CA3C
		public FSpineData()
		{
		}

		// Token: 0x06025143 RID: 151875 RVA: 0x0036E844 File Offset: 0x0036CA44
		public FSpineData(string Name, bool NeedLoop)
		{
			this.Name = Name;
			this.NeedLoop = NeedLoop;
		}

		// Token: 0x06025144 RID: 151876 RVA: 0x0036E85A File Offset: 0x0036CA5A
		protected override IntPtr GetUStructPtr()
		{
			return FSpineData.StaticStruct();
		}

		// Token: 0x06025145 RID: 151877 RVA: 0x0036E866 File Offset: 0x0036CA66
		[NullableContext(2)]
		public FSpineData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025146 RID: 151878 RVA: 0x0036E870 File Offset: 0x0036CA70
		public FSpineData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025147 RID: 151879 RVA: 0x0036E87B File Offset: 0x0036CA7B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineData(Pointer, false, true);
		}

		// Token: 0x06025148 RID: 151880 RVA: 0x0036E885 File Offset: 0x0036CA85
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineData(Pointer, MemoryOwner);
		}

		// Token: 0x04013F89 RID: 81801
		public const string __ObjectPath = "/Script/SequenceDialogue.SpineData";

		// Token: 0x04013F8A RID: 81802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F8B RID: 81803
		internal static int __PropertyOffset_Name;

		// Token: 0x04013F8C RID: 81804
		internal static int __PropertyOffset_NeedLoop;
	}
}
