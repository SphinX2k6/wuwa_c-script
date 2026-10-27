using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002690 RID: 9872
	[UnrealObjectPath("/Script/Renderer.MyLine")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMyLine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024A6A RID: 150122 RVA: 0x003643A4 File Offset: 0x003625A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMyLine._ScriptStructPtr != 0) ? FMyLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.MyLine", ref FMyLine._ScriptStructPtr);
		}

		// Token: 0x17008D5C RID: 36188
		// (get) Token: 0x06024A6B RID: 150123 RVA: 0x003643C8 File Offset: 0x003625C8
		// (set) Token: 0x06024A6C RID: 150124 RVA: 0x003643DC File Offset: 0x003625DC
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyLine.__PropertyOffset_startPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyLine.__PropertyOffset_startPos) = value;
			}
		}

		// Token: 0x17008D5D RID: 36189
		// (get) Token: 0x06024A6D RID: 150125 RVA: 0x003643F1 File Offset: 0x003625F1
		// (set) Token: 0x06024A6E RID: 150126 RVA: 0x00364405 File Offset: 0x00362605
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyLine.__PropertyOffset_endPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyLine.__PropertyOffset_endPos) = value;
			}
		}

		// Token: 0x06024A6F RID: 150127 RVA: 0x0036441A File Offset: 0x0036261A
		public FMyLine()
		{
		}

		// Token: 0x06024A70 RID: 150128 RVA: 0x00364422 File Offset: 0x00362622
		public FMyLine(FVector startPos, FVector endPos)
		{
			this.startPos = startPos;
			this.endPos = endPos;
		}

		// Token: 0x06024A71 RID: 150129 RVA: 0x00364438 File Offset: 0x00362638
		protected override IntPtr GetUStructPtr()
		{
			return FMyLine.StaticStruct();
		}

		// Token: 0x06024A72 RID: 150130 RVA: 0x00364444 File Offset: 0x00362644
		[NullableContext(2)]
		public FMyLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024A73 RID: 150131 RVA: 0x0036444E File Offset: 0x0036264E
		public FMyLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024A74 RID: 150132 RVA: 0x00364459 File Offset: 0x00362659
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMyLine(Pointer, false, true);
		}

		// Token: 0x06024A75 RID: 150133 RVA: 0x00364463 File Offset: 0x00362663
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMyLine(Pointer, MemoryOwner);
		}

		// Token: 0x04013B52 RID: 80722
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.MyLine";

		// Token: 0x04013B53 RID: 80723
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B54 RID: 80724
		internal static int __PropertyOffset_startPos;

		// Token: 0x04013B55 RID: 80725
		internal static int __PropertyOffset_endPos;
	}
}
