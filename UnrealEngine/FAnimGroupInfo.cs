using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000808 RID: 2056
	[UnrealObjectPath("/Script/Engine.AnimGroupInfo")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FAnimGroupInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D8B RID: 28043 RVA: 0x0009DA0F File Offset: 0x0009BC0F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimGroupInfo._ScriptStructPtr != 0) ? FAnimGroupInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimGroupInfo", ref FAnimGroupInfo._ScriptStructPtr);
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06006D8C RID: 28044 RVA: 0x0009DA33 File Offset: 0x0009BC33
		// (set) Token: 0x06006D8D RID: 28045 RVA: 0x0009DA47 File Offset: 0x0009BC47
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimGroupInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimGroupInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x0009DA5C File Offset: 0x0009BC5C
		// (set) Token: 0x06006D8F RID: 28047 RVA: 0x0009DA70 File Offset: 0x0009BC70
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimGroupInfo.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimGroupInfo.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x0009DA85 File Offset: 0x0009BC85
		public FAnimGroupInfo()
		{
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x0009DA8D File Offset: 0x0009BC8D
		public FAnimGroupInfo(FName Name, FLinearColor Color)
		{
			this.Name = Name;
			this.Color = Color;
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x0009DAA3 File Offset: 0x0009BCA3
		protected override IntPtr GetUStructPtr()
		{
			return FAnimGroupInfo.StaticStruct();
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x0009DAAF File Offset: 0x0009BCAF
		[NullableContext(2)]
		public FAnimGroupInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x0009DAB9 File Offset: 0x0009BCB9
		public FAnimGroupInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x0009DAC4 File Offset: 0x0009BCC4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimGroupInfo(Pointer, false, true);
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x0009DACE File Offset: 0x0009BCCE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimGroupInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040034E8 RID: 13544
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimGroupInfo";

		// Token: 0x040034E9 RID: 13545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040034EA RID: 13546
		internal static int __PropertyOffset_Name;

		// Token: 0x040034EB RID: 13547
		internal static int __PropertyOffset_Color;
	}
}
