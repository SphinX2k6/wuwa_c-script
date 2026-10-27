using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001013 RID: 4115
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PluginRedirect")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPluginRedirect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E0F9 RID: 57593 RVA: 0x0014AD12 File Offset: 0x00148F12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPluginRedirect._ScriptStructPtr != 0) ? FPluginRedirect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PluginRedirect", ref FPluginRedirect._ScriptStructPtr);
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600E0FA RID: 57594 RVA: 0x0014AD36 File Offset: 0x00148F36
		// (set) Token: 0x0600E0FB RID: 57595 RVA: 0x0014AD4A File Offset: 0x00148F4A
		public unsafe string OldPluginName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPluginRedirect.__PropertyOffset_OldPluginName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPluginRedirect.__PropertyOffset_OldPluginName)), value);
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600E0FC RID: 57596 RVA: 0x0014AD5F File Offset: 0x00148F5F
		// (set) Token: 0x0600E0FD RID: 57597 RVA: 0x0014AD73 File Offset: 0x00148F73
		public unsafe string NewPluginName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPluginRedirect.__PropertyOffset_NewPluginName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPluginRedirect.__PropertyOffset_NewPluginName)), value);
			}
		}

		// Token: 0x0600E0FE RID: 57598 RVA: 0x0014AD88 File Offset: 0x00148F88
		public FPluginRedirect()
		{
		}

		// Token: 0x0600E0FF RID: 57599 RVA: 0x0014AD90 File Offset: 0x00148F90
		public FPluginRedirect(string OldPluginName, string NewPluginName)
		{
			this.OldPluginName = OldPluginName;
			this.NewPluginName = NewPluginName;
		}

		// Token: 0x0600E100 RID: 57600 RVA: 0x0014ADA6 File Offset: 0x00148FA6
		protected override IntPtr GetUStructPtr()
		{
			return FPluginRedirect.StaticStruct();
		}

		// Token: 0x0600E101 RID: 57601 RVA: 0x0014ADB2 File Offset: 0x00148FB2
		[NullableContext(2)]
		public FPluginRedirect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E102 RID: 57602 RVA: 0x0014ADBC File Offset: 0x00148FBC
		public FPluginRedirect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E103 RID: 57603 RVA: 0x0014ADC7 File Offset: 0x00148FC7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPluginRedirect(Pointer, false, true);
		}

		// Token: 0x0600E104 RID: 57604 RVA: 0x0014ADD1 File Offset: 0x00148FD1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPluginRedirect(Pointer, MemoryOwner);
		}

		// Token: 0x040078DA RID: 30938
		public const string __ObjectPath = "/Script/Engine.PluginRedirect";

		// Token: 0x040078DB RID: 30939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040078DC RID: 30940
		internal static int __PropertyOffset_OldPluginName;

		// Token: 0x040078DD RID: 30941
		internal static int __PropertyOffset_NewPluginName;
	}
}
