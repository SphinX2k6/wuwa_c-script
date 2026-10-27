using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002696 RID: 9878
	[UnrealObjectPath("/Script/Renderer.PlainVec4")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPlainVec4 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024ACD RID: 150221 RVA: 0x00364C06 File Offset: 0x00362E06
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlainVec4._ScriptStructPtr != 0) ? FPlainVec4._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.PlainVec4", ref FPlainVec4._ScriptStructPtr);
		}

		// Token: 0x17008D75 RID: 36213
		// (get) Token: 0x06024ACE RID: 150222 RVA: 0x00364C2A File Offset: 0x00362E2A
		// (set) Token: 0x06024ACF RID: 150223 RVA: 0x00364C3A File Offset: 0x00362E3A
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_X) = value;
			}
		}

		// Token: 0x17008D76 RID: 36214
		// (get) Token: 0x06024AD0 RID: 150224 RVA: 0x00364C4B File Offset: 0x00362E4B
		// (set) Token: 0x06024AD1 RID: 150225 RVA: 0x00364C5B File Offset: 0x00362E5B
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_Y) = value;
			}
		}

		// Token: 0x17008D77 RID: 36215
		// (get) Token: 0x06024AD2 RID: 150226 RVA: 0x00364C6C File Offset: 0x00362E6C
		// (set) Token: 0x06024AD3 RID: 150227 RVA: 0x00364C7C File Offset: 0x00362E7C
		public unsafe float Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_Z);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_Z) = value;
			}
		}

		// Token: 0x17008D78 RID: 36216
		// (get) Token: 0x06024AD4 RID: 150228 RVA: 0x00364C8D File Offset: 0x00362E8D
		// (set) Token: 0x06024AD5 RID: 150229 RVA: 0x00364C9D File Offset: 0x00362E9D
		public unsafe float W
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_W);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlainVec4.__PropertyOffset_W) = value;
			}
		}

		// Token: 0x06024AD6 RID: 150230 RVA: 0x00364CAE File Offset: 0x00362EAE
		public FPlainVec4()
		{
		}

		// Token: 0x06024AD7 RID: 150231 RVA: 0x00364CB6 File Offset: 0x00362EB6
		public FPlainVec4(float X, float Y, float Z, float W)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.W = W;
		}

		// Token: 0x06024AD8 RID: 150232 RVA: 0x00364CDB File Offset: 0x00362EDB
		protected override IntPtr GetUStructPtr()
		{
			return FPlainVec4.StaticStruct();
		}

		// Token: 0x06024AD9 RID: 150233 RVA: 0x00364CE7 File Offset: 0x00362EE7
		[NullableContext(2)]
		public FPlainVec4(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024ADA RID: 150234 RVA: 0x00364CF1 File Offset: 0x00362EF1
		public FPlainVec4(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024ADB RID: 150235 RVA: 0x00364CFC File Offset: 0x00362EFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlainVec4(Pointer, false, true);
		}

		// Token: 0x06024ADC RID: 150236 RVA: 0x00364D06 File Offset: 0x00362F06
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlainVec4(Pointer, MemoryOwner);
		}

		// Token: 0x04013B7C RID: 80764
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.PlainVec4";

		// Token: 0x04013B7D RID: 80765
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B7E RID: 80766
		internal static int __PropertyOffset_X;

		// Token: 0x04013B7F RID: 80767
		internal static int __PropertyOffset_Y;

		// Token: 0x04013B80 RID: 80768
		internal static int __PropertyOffset_Z;

		// Token: 0x04013B81 RID: 80769
		internal static int __PropertyOffset_W;
	}
}
