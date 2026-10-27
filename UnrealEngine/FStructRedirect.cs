using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011B4 RID: 4532
	[UnrealObjectPath("/Script/Engine.StructRedirect")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FStructRedirect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B5A RID: 68442 RVA: 0x001888B2 File Offset: 0x00186AB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructRedirect._ScriptStructPtr != 0) ? FStructRedirect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StructRedirect", ref FStructRedirect._ScriptStructPtr);
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x06010B5B RID: 68443 RVA: 0x001888D6 File Offset: 0x00186AD6
		// (set) Token: 0x06010B5C RID: 68444 RVA: 0x001888EA File Offset: 0x00186AEA
		public unsafe FName OldStructName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructRedirect.__PropertyOffset_OldStructName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructRedirect.__PropertyOffset_OldStructName) = value;
			}
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x06010B5D RID: 68445 RVA: 0x001888FF File Offset: 0x00186AFF
		// (set) Token: 0x06010B5E RID: 68446 RVA: 0x00188913 File Offset: 0x00186B13
		public unsafe FName NewStructName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructRedirect.__PropertyOffset_NewStructName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructRedirect.__PropertyOffset_NewStructName) = value;
			}
		}

		// Token: 0x06010B5F RID: 68447 RVA: 0x00188928 File Offset: 0x00186B28
		public FStructRedirect()
		{
		}

		// Token: 0x06010B60 RID: 68448 RVA: 0x00188930 File Offset: 0x00186B30
		public FStructRedirect(FName OldStructName, FName NewStructName)
		{
			this.OldStructName = OldStructName;
			this.NewStructName = NewStructName;
		}

		// Token: 0x06010B61 RID: 68449 RVA: 0x00188946 File Offset: 0x00186B46
		protected override IntPtr GetUStructPtr()
		{
			return FStructRedirect.StaticStruct();
		}

		// Token: 0x06010B62 RID: 68450 RVA: 0x00188952 File Offset: 0x00186B52
		[NullableContext(2)]
		public FStructRedirect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B63 RID: 68451 RVA: 0x0018895C File Offset: 0x00186B5C
		public FStructRedirect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B64 RID: 68452 RVA: 0x00188967 File Offset: 0x00186B67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructRedirect(Pointer, false, true);
		}

		// Token: 0x06010B65 RID: 68453 RVA: 0x00188971 File Offset: 0x00186B71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructRedirect(Pointer, MemoryOwner);
		}

		// Token: 0x04008EF4 RID: 36596
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StructRedirect";

		// Token: 0x04008EF5 RID: 36597
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EF6 RID: 36598
		internal static int __PropertyOffset_OldStructName;

		// Token: 0x04008EF7 RID: 36599
		internal static int __PropertyOffset_NewStructName;
	}
}
