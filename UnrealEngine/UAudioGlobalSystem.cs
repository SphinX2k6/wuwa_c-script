using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036F RID: 879
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMaterialPlugin.AudioGlobalSystem")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAudioGlobalSystem : UAudioGlobalSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600304B RID: 12363 RVA: 0x0004AC89 File Offset: 0x00048E89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioGlobalSystem._ClassPtr;
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0004AC98 File Offset: 0x00048E98
		public UAudioGlobalSystem() : this(BuiltinUtils.AllocNativeUObject(UAudioGlobalSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0004ACC0 File Offset: 0x00048EC0
		public UAudioGlobalSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioGlobalSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x0004ACF4 File Offset: 0x00048EF4
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x0004AD2D File Offset: 0x00048F2D
		public TArray<UAudioMaterialComponent> AudioComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAudioMaterialComponent> result;
				if ((result = this._AudioComponents) == null)
				{
					result = (this._AudioComponents = new TArray<UAudioMaterialComponent>(base.NativePtr + (IntPtr)UAudioGlobalSystem.__PropertyOffset_AudioComponents, this));
				}
				return result;
			}
			set
			{
				this.AudioComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x0004AD3B File Offset: 0x00048F3B
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x0004AD4B File Offset: 0x00048F4B
		public unsafe bool bOpenLogging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioGlobalSystem.__PropertyOffset_bOpenLogging) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioGlobalSystem.__PropertyOffset_bOpenLogging) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x0004AD5C File Offset: 0x00048F5C
		static UAudioGlobalSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMaterialPlugin.AudioGlobalSystem");
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0004AD6A File Offset: 0x00048F6A
		protected UAudioGlobalSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400150A RID: 5386
		public new const string __ObjectPath = "/Script/AudioMaterialPlugin.AudioGlobalSystem";

		// Token: 0x0400150B RID: 5387
		private static IntPtr _ClassPtr;

		// Token: 0x0400150C RID: 5388
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400150D RID: 5389
		internal static int __PropertyOffset_AudioComponents;

		// Token: 0x0400150E RID: 5390
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAudioMaterialComponent> _AudioComponents;

		// Token: 0x0400150F RID: 5391
		internal static int __PropertyOffset_bOpenLogging;
	}
}
