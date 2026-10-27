using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000807 RID: 2055
	[UnrealObjectPath("/Script/Engine.AnimGraphBlendOptions")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAnimGraphBlendOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D7F RID: 28031 RVA: 0x0009D957 File Offset: 0x0009BB57
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimGraphBlendOptions._ScriptStructPtr != 0) ? FAnimGraphBlendOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimGraphBlendOptions", ref FAnimGraphBlendOptions._ScriptStructPtr);
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06006D80 RID: 28032 RVA: 0x0009D97B File Offset: 0x0009BB7B
		// (set) Token: 0x06006D81 RID: 28033 RVA: 0x0009D98B File Offset: 0x0009BB8B
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimGraphBlendOptions.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimGraphBlendOptions.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06006D82 RID: 28034 RVA: 0x0009D99C File Offset: 0x0009BB9C
		// (set) Token: 0x06006D83 RID: 28035 RVA: 0x0009D9AC File Offset: 0x0009BBAC
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimGraphBlendOptions.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimGraphBlendOptions.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x0009D9BD File Offset: 0x0009BBBD
		public FAnimGraphBlendOptions()
		{
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x0009D9C5 File Offset: 0x0009BBC5
		public FAnimGraphBlendOptions(float BlendInTime, float BlendOutTime)
		{
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x0009D9DB File Offset: 0x0009BBDB
		protected override IntPtr GetUStructPtr()
		{
			return FAnimGraphBlendOptions.StaticStruct();
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x0009D9E7 File Offset: 0x0009BBE7
		[NullableContext(2)]
		public FAnimGraphBlendOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x0009D9F1 File Offset: 0x0009BBF1
		public FAnimGraphBlendOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x0009D9FC File Offset: 0x0009BBFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimGraphBlendOptions(Pointer, false, true);
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x0009DA06 File Offset: 0x0009BC06
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimGraphBlendOptions(Pointer, MemoryOwner);
		}

		// Token: 0x040034E4 RID: 13540
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimGraphBlendOptions";

		// Token: 0x040034E5 RID: 13541
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040034E6 RID: 13542
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x040034E7 RID: 13543
		internal static int __PropertyOffset_BlendOutTime;
	}
}
