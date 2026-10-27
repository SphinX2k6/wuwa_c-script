using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EE8 RID: 3816
	[UnrealObjectPath("/Script/Engine.NetDriverDefinition")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FNetDriverDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CEF5 RID: 52981 RVA: 0x0012DFF9 File Offset: 0x0012C1F9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNetDriverDefinition._ScriptStructPtr != 0) ? FNetDriverDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NetDriverDefinition", ref FNetDriverDefinition._ScriptStructPtr);
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600CEF6 RID: 52982 RVA: 0x0012E01D File Offset: 0x0012C21D
		// (set) Token: 0x0600CEF7 RID: 52983 RVA: 0x0012E031 File Offset: 0x0012C231
		public unsafe FName DefName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetDriverDefinition.__PropertyOffset_DefName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetDriverDefinition.__PropertyOffset_DefName) = value;
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600CEF8 RID: 52984 RVA: 0x0012E046 File Offset: 0x0012C246
		// (set) Token: 0x0600CEF9 RID: 52985 RVA: 0x0012E05A File Offset: 0x0012C25A
		public unsafe FName DriverClassName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetDriverDefinition.__PropertyOffset_DriverClassName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetDriverDefinition.__PropertyOffset_DriverClassName) = value;
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600CEFA RID: 52986 RVA: 0x0012E06F File Offset: 0x0012C26F
		// (set) Token: 0x0600CEFB RID: 52987 RVA: 0x0012E083 File Offset: 0x0012C283
		public unsafe FName DriverClassNameFallback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetDriverDefinition.__PropertyOffset_DriverClassNameFallback);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetDriverDefinition.__PropertyOffset_DriverClassNameFallback) = value;
			}
		}

		// Token: 0x0600CEFC RID: 52988 RVA: 0x0012E098 File Offset: 0x0012C298
		public FNetDriverDefinition()
		{
		}

		// Token: 0x0600CEFD RID: 52989 RVA: 0x0012E0A0 File Offset: 0x0012C2A0
		public FNetDriverDefinition(FName DefName, FName DriverClassName, FName DriverClassNameFallback)
		{
			this.DefName = DefName;
			this.DriverClassName = DriverClassName;
			this.DriverClassNameFallback = DriverClassNameFallback;
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x0012E0BD File Offset: 0x0012C2BD
		protected override IntPtr GetUStructPtr()
		{
			return FNetDriverDefinition.StaticStruct();
		}

		// Token: 0x0600CEFF RID: 52991 RVA: 0x0012E0C9 File Offset: 0x0012C2C9
		[NullableContext(2)]
		public FNetDriverDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF00 RID: 52992 RVA: 0x0012E0D3 File Offset: 0x0012C2D3
		public FNetDriverDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF01 RID: 52993 RVA: 0x0012E0DE File Offset: 0x0012C2DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNetDriverDefinition(Pointer, false, true);
		}

		// Token: 0x0600CF02 RID: 52994 RVA: 0x0012E0E8 File Offset: 0x0012C2E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNetDriverDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04006FA4 RID: 28580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NetDriverDefinition";

		// Token: 0x04006FA5 RID: 28581
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006FA6 RID: 28582
		internal static int __PropertyOffset_DefName;

		// Token: 0x04006FA7 RID: 28583
		internal static int __PropertyOffset_DriverClassName;

		// Token: 0x04006FA8 RID: 28584
		internal static int __PropertyOffset_DriverClassNameFallback;
	}
}
