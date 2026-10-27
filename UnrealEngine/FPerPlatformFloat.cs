using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FD8 RID: 4056
	[UnrealObjectPath("/Script/Engine.PerPlatformFloat")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FPerPlatformFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DB12 RID: 56082 RVA: 0x00142E17 File Offset: 0x00141017
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerPlatformFloat._ScriptStructPtr != 0) ? FPerPlatformFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerPlatformFloat", ref FPerPlatformFloat._ScriptStructPtr);
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600DB13 RID: 56083 RVA: 0x00142E3B File Offset: 0x0014103B
		// (set) Token: 0x0600DB14 RID: 56084 RVA: 0x00142E4B File Offset: 0x0014104B
		public unsafe float Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerPlatformFloat.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerPlatformFloat.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x0600DB15 RID: 56085 RVA: 0x00142E5C File Offset: 0x0014105C
		public FPerPlatformFloat()
		{
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00142E64 File Offset: 0x00141064
		[NullableContext(1)]
		public FPerPlatformFloat(float Default, TMap<FName, float> PerPlatform)
		{
			this.Default = Default;
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00142E73 File Offset: 0x00141073
		protected override IntPtr GetUStructPtr()
		{
			return FPerPlatformFloat.StaticStruct();
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x00142E7F File Offset: 0x0014107F
		[NullableContext(2)]
		public FPerPlatformFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x00142E89 File Offset: 0x00141089
		public FPerPlatformFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00142E94 File Offset: 0x00141094
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerPlatformFloat(Pointer, false, true);
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x00142E9E File Offset: 0x0014109E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerPlatformFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04007693 RID: 30355
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PerPlatformFloat";

		// Token: 0x04007694 RID: 30356
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007695 RID: 30357
		internal static int __PropertyOffset_Default;
	}
}
