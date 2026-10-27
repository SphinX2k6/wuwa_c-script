using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A8 RID: 424
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryRequest")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FEnvQueryRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060019EF RID: 6639 RVA: 0x00026792 File Offset: 0x00024992
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvQueryRequest._ScriptStructPtr != 0) ? FEnvQueryRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvQueryRequest", ref FEnvQueryRequest._ScriptStructPtr);
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x000267B6 File Offset: 0x000249B6
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x000267CA File Offset: 0x000249CA
		public unsafe UEnvQuery QueryTemplate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQuery>(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryRequest.__PropertyOffset_QueryTemplate);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryRequest.__PropertyOffset_QueryTemplate, value);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000267DF File Offset: 0x000249DF
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x000267F3 File Offset: 0x000249F3
		public unsafe UObject Owner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryRequest.__PropertyOffset_Owner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryRequest.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00026808 File Offset: 0x00024A08
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0002681C File Offset: 0x00024A1C
		public unsafe UWorld World
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryRequest.__PropertyOffset_World);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryRequest.__PropertyOffset_World, value);
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00026831 File Offset: 0x00024A31
		public FEnvQueryRequest()
		{
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00026839 File Offset: 0x00024A39
		[NullableContext(1)]
		public FEnvQueryRequest(UEnvQuery QueryTemplate, UObject Owner, UWorld World)
		{
			this.QueryTemplate = QueryTemplate;
			this.Owner = Owner;
			this.World = World;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00026856 File Offset: 0x00024A56
		protected override IntPtr GetUStructPtr()
		{
			return FEnvQueryRequest.StaticStruct();
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00026862 File Offset: 0x00024A62
		public FEnvQueryRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0002686C File Offset: 0x00024A6C
		public FEnvQueryRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00026877 File Offset: 0x00024A77
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvQueryRequest(Pointer, false, true);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00026881 File Offset: 0x00024A81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvQueryRequest(Pointer, MemoryOwner);
		}

		// Token: 0x040007B1 RID: 1969
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvQueryRequest";

		// Token: 0x040007B2 RID: 1970
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040007B3 RID: 1971
		internal static int __PropertyOffset_QueryTemplate;

		// Token: 0x040007B4 RID: 1972
		internal static int __PropertyOffset_Owner;

		// Token: 0x040007B5 RID: 1973
		internal static int __PropertyOffset_World;
	}
}
