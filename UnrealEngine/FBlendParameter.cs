using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008AF RID: 2223
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlendParameter")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBlendParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600797E RID: 31102 RVA: 0x000ADCFF File Offset: 0x000ABEFF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendParameter._ScriptStructPtr != 0) ? FBlendParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlendParameter", ref FBlendParameter._ScriptStructPtr);
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x000ADD23 File Offset: 0x000ABF23
		// (set) Token: 0x06007980 RID: 31104 RVA: 0x000ADD37 File Offset: 0x000ABF37
		public unsafe string DisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBlendParameter.__PropertyOffset_DisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBlendParameter.__PropertyOffset_DisplayName)), value);
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06007981 RID: 31105 RVA: 0x000ADD4C File Offset: 0x000ABF4C
		// (set) Token: 0x06007982 RID: 31106 RVA: 0x000ADD5C File Offset: 0x000ABF5C
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendParameter.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendParameter.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06007983 RID: 31107 RVA: 0x000ADD6D File Offset: 0x000ABF6D
		// (set) Token: 0x06007984 RID: 31108 RVA: 0x000ADD7D File Offset: 0x000ABF7D
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendParameter.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendParameter.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06007985 RID: 31109 RVA: 0x000ADD8E File Offset: 0x000ABF8E
		// (set) Token: 0x06007986 RID: 31110 RVA: 0x000ADD9E File Offset: 0x000ABF9E
		public unsafe int GridNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendParameter.__PropertyOffset_GridNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendParameter.__PropertyOffset_GridNum) = value;
			}
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x000ADDAF File Offset: 0x000ABFAF
		public FBlendParameter()
		{
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x000ADDB7 File Offset: 0x000ABFB7
		public FBlendParameter(string DisplayName, float Min, float Max, int GridNum)
		{
			this.DisplayName = DisplayName;
			this.Min = Min;
			this.Max = Max;
			this.GridNum = GridNum;
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x000ADDDC File Offset: 0x000ABFDC
		protected override IntPtr GetUStructPtr()
		{
			return FBlendParameter.StaticStruct();
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x000ADDE8 File Offset: 0x000ABFE8
		[NullableContext(2)]
		public FBlendParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x000ADDF2 File Offset: 0x000ABFF2
		public FBlendParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x000ADDFD File Offset: 0x000ABFFD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendParameter(Pointer, false, true);
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x000ADE07 File Offset: 0x000AC007
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04003A62 RID: 14946
		public const string __ObjectPath = "/Script/Engine.BlendParameter";

		// Token: 0x04003A63 RID: 14947
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A64 RID: 14948
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04003A65 RID: 14949
		internal static int __PropertyOffset_Min;

		// Token: 0x04003A66 RID: 14950
		internal static int __PropertyOffset_Max;

		// Token: 0x04003A67 RID: 14951
		internal static int __PropertyOffset_GridNum;
	}
}
