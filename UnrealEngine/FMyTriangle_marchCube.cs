using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002694 RID: 9876
	[UnrealObjectPath("/Script/Renderer.MyTriangle_marchCube")]
	[UnrealStructLayout(84, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class FMyTriangle_marchCube : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024AA9 RID: 150185 RVA: 0x003648CF File Offset: 0x00362ACF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMyTriangle_marchCube._ScriptStructPtr != 0) ? FMyTriangle_marchCube._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.MyTriangle_marchCube", ref FMyTriangle_marchCube._ScriptStructPtr);
		}

		// Token: 0x17008D6C RID: 36204
		// (get) Token: 0x06024AAA RID: 150186 RVA: 0x003648F3 File Offset: 0x00362AF3
		// (set) Token: 0x06024AAB RID: 150187 RVA: 0x00364907 File Offset: 0x00362B07
		public unsafe FVector vertexA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_vertexA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_vertexA) = value;
			}
		}

		// Token: 0x17008D6D RID: 36205
		// (get) Token: 0x06024AAC RID: 150188 RVA: 0x0036491C File Offset: 0x00362B1C
		// (set) Token: 0x06024AAD RID: 150189 RVA: 0x00364930 File Offset: 0x00362B30
		public unsafe FVector vertexB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_vertexB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_vertexB) = value;
			}
		}

		// Token: 0x17008D6E RID: 36206
		// (get) Token: 0x06024AAE RID: 150190 RVA: 0x00364945 File Offset: 0x00362B45
		// (set) Token: 0x06024AAF RID: 150191 RVA: 0x00364959 File Offset: 0x00362B59
		public unsafe FVector vertexC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_vertexC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_vertexC) = value;
			}
		}

		// Token: 0x17008D6F RID: 36207
		// (get) Token: 0x06024AB0 RID: 150192 RVA: 0x0036496E File Offset: 0x00362B6E
		// (set) Token: 0x06024AB1 RID: 150193 RVA: 0x00364982 File Offset: 0x00362B82
		public unsafe FVector normalA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_normalA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_normalA) = value;
			}
		}

		// Token: 0x17008D70 RID: 36208
		// (get) Token: 0x06024AB2 RID: 150194 RVA: 0x00364997 File Offset: 0x00362B97
		// (set) Token: 0x06024AB3 RID: 150195 RVA: 0x003649AB File Offset: 0x00362BAB
		public unsafe FVector normalB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_normalB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_normalB) = value;
			}
		}

		// Token: 0x17008D71 RID: 36209
		// (get) Token: 0x06024AB4 RID: 150196 RVA: 0x003649C0 File Offset: 0x00362BC0
		// (set) Token: 0x06024AB5 RID: 150197 RVA: 0x003649D4 File Offset: 0x00362BD4
		public unsafe FVector normalC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_normalC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_normalC) = value;
			}
		}

		// Token: 0x17008D72 RID: 36210
		// (get) Token: 0x06024AB6 RID: 150198 RVA: 0x003649E9 File Offset: 0x00362BE9
		// (set) Token: 0x06024AB7 RID: 150199 RVA: 0x003649FD File Offset: 0x00362BFD
		public unsafe FColor colorA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_colorA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_colorA) = value;
			}
		}

		// Token: 0x17008D73 RID: 36211
		// (get) Token: 0x06024AB8 RID: 150200 RVA: 0x00364A12 File Offset: 0x00362C12
		// (set) Token: 0x06024AB9 RID: 150201 RVA: 0x00364A26 File Offset: 0x00362C26
		public unsafe FColor colorB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_colorB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_colorB) = value;
			}
		}

		// Token: 0x17008D74 RID: 36212
		// (get) Token: 0x06024ABA RID: 150202 RVA: 0x00364A3B File Offset: 0x00362C3B
		// (set) Token: 0x06024ABB RID: 150203 RVA: 0x00364A4F File Offset: 0x00362C4F
		public unsafe FColor colorC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_colorC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMyTriangle_marchCube.__PropertyOffset_colorC) = value;
			}
		}

		// Token: 0x06024ABC RID: 150204 RVA: 0x00364A64 File Offset: 0x00362C64
		public FMyTriangle_marchCube()
		{
		}

		// Token: 0x06024ABD RID: 150205 RVA: 0x00364A6C File Offset: 0x00362C6C
		public FMyTriangle_marchCube(FVector vertexA, FVector vertexB, FVector vertexC, FVector normalA, FVector normalB, FVector normalC, FColor colorA, FColor colorB, FColor colorC)
		{
			this.vertexA = vertexA;
			this.vertexB = vertexB;
			this.vertexC = vertexC;
			this.normalA = normalA;
			this.normalB = normalB;
			this.normalC = normalC;
			this.colorA = colorA;
			this.colorB = colorB;
			this.colorC = colorC;
		}

		// Token: 0x06024ABE RID: 150206 RVA: 0x00364AC4 File Offset: 0x00362CC4
		protected override IntPtr GetUStructPtr()
		{
			return FMyTriangle_marchCube.StaticStruct();
		}

		// Token: 0x06024ABF RID: 150207 RVA: 0x00364AD0 File Offset: 0x00362CD0
		[NullableContext(2)]
		public FMyTriangle_marchCube(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024AC0 RID: 150208 RVA: 0x00364ADA File Offset: 0x00362CDA
		public FMyTriangle_marchCube(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024AC1 RID: 150209 RVA: 0x00364AE5 File Offset: 0x00362CE5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMyTriangle_marchCube(Pointer, false, true);
		}

		// Token: 0x06024AC2 RID: 150210 RVA: 0x00364AEF File Offset: 0x00362CEF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMyTriangle_marchCube(Pointer, MemoryOwner);
		}

		// Token: 0x04013B6E RID: 80750
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.MyTriangle_marchCube";

		// Token: 0x04013B6F RID: 80751
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B70 RID: 80752
		internal static int __PropertyOffset_vertexA;

		// Token: 0x04013B71 RID: 80753
		internal static int __PropertyOffset_vertexB;

		// Token: 0x04013B72 RID: 80754
		internal static int __PropertyOffset_vertexC;

		// Token: 0x04013B73 RID: 80755
		internal static int __PropertyOffset_normalA;

		// Token: 0x04013B74 RID: 80756
		internal static int __PropertyOffset_normalB;

		// Token: 0x04013B75 RID: 80757
		internal static int __PropertyOffset_normalC;

		// Token: 0x04013B76 RID: 80758
		internal static int __PropertyOffset_colorA;

		// Token: 0x04013B77 RID: 80759
		internal static int __PropertyOffset_colorB;

		// Token: 0x04013B78 RID: 80760
		internal static int __PropertyOffset_colorC;
	}
}
