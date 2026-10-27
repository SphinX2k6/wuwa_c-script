using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008AE RID: 2222
	[UnrealObjectPath("/Script/Engine.BlendFilter")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FBlendFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007977 RID: 31095 RVA: 0x000ADC9F File Offset: 0x000ABE9F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendFilter._ScriptStructPtr != 0) ? FBlendFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlendFilter", ref FBlendFilter._ScriptStructPtr);
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x000ADCC3 File Offset: 0x000ABEC3
		public FBlendFilter()
		{
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x000ADCCB File Offset: 0x000ABECB
		protected override IntPtr GetUStructPtr()
		{
			return FBlendFilter.StaticStruct();
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x000ADCD7 File Offset: 0x000ABED7
		[NullableContext(2)]
		public FBlendFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x000ADCE1 File Offset: 0x000ABEE1
		public FBlendFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x000ADCEC File Offset: 0x000ABEEC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendFilter(Pointer, false, true);
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x000ADCF6 File Offset: 0x000ABEF6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04003A60 RID: 14944
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlendFilter";

		// Token: 0x04003A61 RID: 14945
		private static IntPtr _ScriptStructPtr;
	}
}
