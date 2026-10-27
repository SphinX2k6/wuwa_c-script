using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B6C RID: 7020
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedTexture")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroMaterialNamedTexture : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A91A RID: 108826 RVA: 0x00272C06 File Offset: 0x00270E06
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedTexture._ScriptStructPtr != 0) ? FKuroMaterialNamedTexture._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedTexture", ref FKuroMaterialNamedTexture._ScriptStructPtr);
		}

		// Token: 0x17006AC1 RID: 27329
		// (get) Token: 0x0601A91B RID: 108827 RVA: 0x00272C2A File Offset: 0x00270E2A
		// (set) Token: 0x0601A91C RID: 108828 RVA: 0x00272C3E File Offset: 0x00270E3E
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedTexture.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedTexture.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006AC2 RID: 27330
		// (get) Token: 0x0601A91D RID: 108829 RVA: 0x00272C53 File Offset: 0x00270E53
		// (set) Token: 0x0601A91E RID: 108830 RVA: 0x00272C67 File Offset: 0x00270E67
		[Nullable(2)]
		public unsafe UTexture Value
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialNamedTexture.__PropertyOffset_Value);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialNamedTexture.__PropertyOffset_Value, value);
			}
		}

		// Token: 0x0601A91F RID: 108831 RVA: 0x00272C7C File Offset: 0x00270E7C
		public FKuroMaterialNamedTexture()
		{
		}

		// Token: 0x0601A920 RID: 108832 RVA: 0x00272C84 File Offset: 0x00270E84
		[NullableContext(1)]
		public FKuroMaterialNamedTexture(FName Name, UTexture Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601A921 RID: 108833 RVA: 0x00272C9A File Offset: 0x00270E9A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedTexture.StaticStruct();
		}

		// Token: 0x0601A922 RID: 108834 RVA: 0x00272CA6 File Offset: 0x00270EA6
		[NullableContext(2)]
		public FKuroMaterialNamedTexture(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A923 RID: 108835 RVA: 0x00272CB0 File Offset: 0x00270EB0
		public FKuroMaterialNamedTexture(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A924 RID: 108836 RVA: 0x00272CBB File Offset: 0x00270EBB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedTexture(Pointer, false, true);
		}

		// Token: 0x0601A925 RID: 108837 RVA: 0x00272CC5 File Offset: 0x00270EC5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedTexture(Pointer, MemoryOwner);
		}

		// Token: 0x0400E62A RID: 58922
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedTexture";

		// Token: 0x0400E62B RID: 58923
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E62C RID: 58924
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E62D RID: 58925
		internal static int __PropertyOffset_Value;
	}
}
