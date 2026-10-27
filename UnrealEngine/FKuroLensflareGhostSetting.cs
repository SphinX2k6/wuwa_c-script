using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200268C RID: 9868
	[UnrealObjectPath("/Script/Renderer.KuroLensflareGhostSetting")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroLensflareGhostSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024A05 RID: 150021 RVA: 0x003639D9 File Offset: 0x00361BD9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLensflareGhostSetting._ScriptStructPtr != 0) ? FKuroLensflareGhostSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Renderer.KuroLensflareGhostSetting", ref FKuroLensflareGhostSetting._ScriptStructPtr);
		}

		// Token: 0x17008D38 RID: 36152
		// (get) Token: 0x06024A06 RID: 150022 RVA: 0x003639FD File Offset: 0x00361BFD
		// (set) Token: 0x06024A07 RID: 150023 RVA: 0x00363A0D File Offset: 0x00361C0D
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareGhostSetting.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareGhostSetting.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17008D39 RID: 36153
		// (get) Token: 0x06024A08 RID: 150024 RVA: 0x00363A1E File Offset: 0x00361C1E
		// (set) Token: 0x06024A09 RID: 150025 RVA: 0x00363A32 File Offset: 0x00361C32
		public unsafe FLinearColor ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareGhostSetting.__PropertyOffset_ColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareGhostSetting.__PropertyOffset_ColorTint) = value;
			}
		}

		// Token: 0x17008D3A RID: 36154
		// (get) Token: 0x06024A0A RID: 150026 RVA: 0x00363A47 File Offset: 0x00361C47
		// (set) Token: 0x06024A0B RID: 150027 RVA: 0x00363A5B File Offset: 0x00361C5B
		public unsafe FVector4 ColorRefine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLensflareGhostSetting.__PropertyOffset_ColorRefine);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLensflareGhostSetting.__PropertyOffset_ColorRefine) = value;
			}
		}

		// Token: 0x06024A0C RID: 150028 RVA: 0x00363A70 File Offset: 0x00361C70
		public FKuroLensflareGhostSetting()
		{
		}

		// Token: 0x06024A0D RID: 150029 RVA: 0x00363A78 File Offset: 0x00361C78
		public FKuroLensflareGhostSetting(float Scale, FLinearColor ColorTint, FVector4 ColorRefine)
		{
			this.Scale = Scale;
			this.ColorTint = ColorTint;
			this.ColorRefine = ColorRefine;
		}

		// Token: 0x06024A0E RID: 150030 RVA: 0x00363A95 File Offset: 0x00361C95
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLensflareGhostSetting.StaticStruct();
		}

		// Token: 0x06024A0F RID: 150031 RVA: 0x00363AA1 File Offset: 0x00361CA1
		[NullableContext(2)]
		public FKuroLensflareGhostSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024A10 RID: 150032 RVA: 0x00363AAB File Offset: 0x00361CAB
		public FKuroLensflareGhostSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024A11 RID: 150033 RVA: 0x00363AB6 File Offset: 0x00361CB6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLensflareGhostSetting(Pointer, false, true);
		}

		// Token: 0x06024A12 RID: 150034 RVA: 0x00363AC0 File Offset: 0x00361CC0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLensflareGhostSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04013B17 RID: 80663
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Renderer.KuroLensflareGhostSetting";

		// Token: 0x04013B18 RID: 80664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013B19 RID: 80665
		internal static int __PropertyOffset_Scale;

		// Token: 0x04013B1A RID: 80666
		internal static int __PropertyOffset_ColorTint;

		// Token: 0x04013B1B RID: 80667
		internal static int __PropertyOffset_ColorRefine;
	}
}
