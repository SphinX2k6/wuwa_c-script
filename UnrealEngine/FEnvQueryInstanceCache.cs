using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019E RID: 414
	[UnrealObjectPath("/Script/AIModule.EnvQueryInstanceCache")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 504)]
	public class FEnvQueryInstanceCache : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x00026106 File Offset: 0x00024306
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvQueryInstanceCache._ScriptStructPtr != 0) ? FEnvQueryInstanceCache._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvQueryInstanceCache", ref FEnvQueryInstanceCache._ScriptStructPtr);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0002612A File Offset: 0x0002432A
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0002613E File Offset: 0x0002433E
		[Nullable(2)]
		public unsafe UEnvQuery Template
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQuery>(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryInstanceCache.__PropertyOffset_Template);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEnvQueryInstanceCache.__PropertyOffset_Template, value);
			}
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00026153 File Offset: 0x00024353
		public FEnvQueryInstanceCache()
		{
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0002615B File Offset: 0x0002435B
		[NullableContext(1)]
		public FEnvQueryInstanceCache(UEnvQuery Template)
		{
			this.Template = Template;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0002616A File Offset: 0x0002436A
		protected override IntPtr GetUStructPtr()
		{
			return FEnvQueryInstanceCache.StaticStruct();
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00026176 File Offset: 0x00024376
		[NullableContext(2)]
		public FEnvQueryInstanceCache(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00026180 File Offset: 0x00024380
		public FEnvQueryInstanceCache(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0002618B File Offset: 0x0002438B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvQueryInstanceCache(Pointer, false, true);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00026195 File Offset: 0x00024395
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvQueryInstanceCache(Pointer, MemoryOwner);
		}

		// Token: 0x04000785 RID: 1925
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvQueryInstanceCache";

		// Token: 0x04000786 RID: 1926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000787 RID: 1927
		internal static int __PropertyOffset_Template;
	}
}
