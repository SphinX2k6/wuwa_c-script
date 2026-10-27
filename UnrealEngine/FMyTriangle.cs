using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002693 RID: 9875
	[UnrealObjectPath("/Script/Renderer.MyTriangle")]
	[UnrealStructLayout(96, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FMyTriangle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024A95 RID: 150165 RVA: 0x00364744 File Offset: 0x00362944
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMyTriangle._ScriptStructPtr != 0) ? FMyTriangle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.MyTriangle", ref FMyTriangle._ScriptStructPtr);
		}

		// Token: 0x17008D66 RID: 36198
		// (get) Token: 0x06024A96 RID: 150166 RVA: 0x00364768 File Offset: 0x00362968
		// (set) Token: 0x06024A97 RID: 150167 RVA: 0x0036477C File Offset: 0x0036297C
		public unsafe FVector vertexA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_vertexA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_vertexA) = value;
			}
		}

		// Token: 0x17008D67 RID: 36199
		// (get) Token: 0x06024A98 RID: 150168 RVA: 0x00364791 File Offset: 0x00362991
		// (set) Token: 0x06024A99 RID: 150169 RVA: 0x003647A5 File Offset: 0x003629A5
		public unsafe FVector normalA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_normalA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_normalA) = value;
			}
		}

		// Token: 0x17008D68 RID: 36200
		// (get) Token: 0x06024A9A RID: 150170 RVA: 0x003647BA File Offset: 0x003629BA
		// (set) Token: 0x06024A9B RID: 150171 RVA: 0x003647CE File Offset: 0x003629CE
		public unsafe FVector vertexB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_vertexB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_vertexB) = value;
			}
		}

		// Token: 0x17008D69 RID: 36201
		// (get) Token: 0x06024A9C RID: 150172 RVA: 0x003647E3 File Offset: 0x003629E3
		// (set) Token: 0x06024A9D RID: 150173 RVA: 0x003647F7 File Offset: 0x003629F7
		public unsafe FVector normalB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_normalB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_normalB) = value;
			}
		}

		// Token: 0x17008D6A RID: 36202
		// (get) Token: 0x06024A9E RID: 150174 RVA: 0x0036480C File Offset: 0x00362A0C
		// (set) Token: 0x06024A9F RID: 150175 RVA: 0x00364820 File Offset: 0x00362A20
		public unsafe FVector vertexC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_vertexC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_vertexC) = value;
			}
		}

		// Token: 0x17008D6B RID: 36203
		// (get) Token: 0x06024AA0 RID: 150176 RVA: 0x00364835 File Offset: 0x00362A35
		// (set) Token: 0x06024AA1 RID: 150177 RVA: 0x00364849 File Offset: 0x00362A49
		public unsafe FVector normalC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_normalC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle.__PropertyOffset_normalC) = value;
			}
		}

		// Token: 0x06024AA2 RID: 150178 RVA: 0x0036485E File Offset: 0x00362A5E
		public FMyTriangle()
		{
		}

		// Token: 0x06024AA3 RID: 150179 RVA: 0x00364866 File Offset: 0x00362A66
		public FMyTriangle(FVector vertexA, FVector normalA, FVector vertexB, FVector normalB, FVector vertexC, FVector normalC)
		{
			this.vertexA = vertexA;
			this.normalA = normalA;
			this.vertexB = vertexB;
			this.normalB = normalB;
			this.vertexC = vertexC;
			this.normalC = normalC;
		}

		// Token: 0x06024AA4 RID: 150180 RVA: 0x0036489B File Offset: 0x00362A9B
		protected override IntPtr GetUStructPtr()
		{
			return FMyTriangle.StaticStruct();
		}

		// Token: 0x06024AA5 RID: 150181 RVA: 0x003648A7 File Offset: 0x00362AA7
		[NullableContext(2)]
		public FMyTriangle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024AA6 RID: 150182 RVA: 0x003648B1 File Offset: 0x00362AB1
		public FMyTriangle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024AA7 RID: 150183 RVA: 0x003648BC File Offset: 0x00362ABC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMyTriangle(Pointer, false, true);
		}

		// Token: 0x06024AA8 RID: 150184 RVA: 0x003648C6 File Offset: 0x00362AC6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMyTriangle(Pointer, MemoryOwner);
		}

		// Token: 0x04013B66 RID: 80742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.MyTriangle";

		// Token: 0x04013B67 RID: 80743
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B68 RID: 80744
		internal static int __PropertyOffset_vertexA;

		// Token: 0x04013B69 RID: 80745
		internal static int __PropertyOffset_normalA;

		// Token: 0x04013B6A RID: 80746
		internal static int __PropertyOffset_vertexB;

		// Token: 0x04013B6B RID: 80747
		internal static int __PropertyOffset_normalB;

		// Token: 0x04013B6C RID: 80748
		internal static int __PropertyOffset_vertexC;

		// Token: 0x04013B6D RID: 80749
		internal static int __PropertyOffset_normalC;
	}
}
